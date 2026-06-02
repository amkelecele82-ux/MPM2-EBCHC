using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 8;
    public Color HoverColor { get; set; } = ColorTranslator.FromHtml("#1E3B1A");
    public Color NormalColor { get; set; } = ColorTranslator.FromHtml("#2D5227");

    private bool _isHovered = false;

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = ColorTranslator.FromHtml("#2D5227");
        this.ForeColor = Color.White;
        this.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.Cursor = Cursors.Hand;
        this.MouseEnter += (s, e) => { _isHovered = true; Invalidate(); };
        this.MouseLeave += (s, e) => { _isHovered = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
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

        Color fillColor = _isHovered ? HoverColor : NormalColor;
        using (SolidBrush brush = new SolidBrush(fillColor))
            g.FillPath(brush, path);

        this.Region = new Region(path);

        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Center;
        sf.LineAlignment = StringAlignment.Center;

        using (SolidBrush textBrush = new SolidBrush(ForeColor))
            g.DrawString(Text, Font, textBrush, rect, sf);
    }
}