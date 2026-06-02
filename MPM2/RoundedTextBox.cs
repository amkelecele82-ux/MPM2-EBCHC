using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private TextBox _textBox;
    public int CornerRadius { get; set; } = 8;
    public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#D4DDD3");
    public bool IsPassword { get; set; } = false;

    public string Text
    {
        get => _textBox.Text;
        set => _textBox.Text = value;
    }

    public char PasswordChar
    {
        get => _textBox.PasswordChar;
        set => _textBox.PasswordChar = value;
    }

    public RoundedTextBox()
    {
        _textBox = new TextBox();
        _textBox.BorderStyle = BorderStyle.None;
        _textBox.Font = new Font("Segoe UI", 10f);
        _textBox.Dock = DockStyle.None;
        _textBox.BackColor = Color.White;

        this.Controls.Add(_textBox);
        this.BackColor = Color.White;
        this.Padding = new Padding(8, 6, 8, 6);
        this.Height = 36;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        _textBox.Width = this.Width - 20;
        _textBox.Top = (this.Height - _textBox.Height) / 2;
        _textBox.Left = 10;
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        GraphicsPath path = new GraphicsPath();
        int d = CornerRadius * 2;
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        this.Region = new Region(path);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        int d = CornerRadius * 2;

        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        using (SolidBrush brush = new SolidBrush(Color.White))
            g.FillPath(brush, path);

        using (Pen pen = new Pen(BorderColor, 1f))
            g.DrawPath(pen, path);
    }
}