using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoleCard : UserControl
{
    private PictureBox picIcon;
    private Label lblTitle;
    private Label lblSub;

    public int CornerRadius { get; set; } = 10;
    public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
    public string SubTitle { get => lblSub.Text; set => lblSub.Text = value; }
    public Image Icon
    {
        get => picIcon.Image;
        set
        {
            picIcon.Image = value;
            picIcon.Refresh();   // ← force picturebox to redraw
        }
    }

    private bool _selected = false;
    public bool Selected
    {
        get => _selected;
        set
        {
            _selected = value;
            UpdateStyle();
            Invalidate();
        }
    }

    public event EventHandler CardClicked;

    public RoleCard()
    {
        this.Size = new Size(210, 68);
        this.Cursor = Cursors.Hand;
        this.BackColor = Color.White;
        this.DoubleBuffered = true;

        picIcon = new PictureBox();
        picIcon.Size = new Size(30, 30);
        picIcon.Location = new Point(10, 19);
        picIcon.SizeMode = PictureBoxSizeMode.StretchImage;  // ← changed from Zoom
        picIcon.BackColor = Color.Transparent;

        lblTitle = new Label();
        lblTitle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(34, 34, 34);
        lblTitle.Location = new Point(48, 8);
        lblTitle.Size = new Size(155, 30);
        lblTitle.AutoSize = false;

        lblSub = new Label();
        lblSub.Font = new Font("Segoe UI", 7.5f, FontStyle.Regular);
        lblSub.ForeColor = Color.FromArgb(119, 119, 119);
        lblSub.Location = new Point(48, 38);
        lblSub.Size = new Size(155, 20);
        lblSub.AutoSize = false;

        this.Controls.Add(picIcon);
        this.Controls.Add(lblTitle);
        this.Controls.Add(lblSub);

        // bring icon to front so nothing covers it
        picIcon.BringToFront();

        this.Click += OnCardClick;
        picIcon.Click += OnCardClick;
        lblTitle.Click += OnCardClick;
        lblSub.Click += OnCardClick;
    }

    private void OnCardClick(object sender, EventArgs e)
    {
        CardClicked?.Invoke(this, e);
    }

    private void UpdateStyle()
    {
        if (_selected)
        {
            this.BackColor = ColorTranslator.FromHtml("#EDF4EB");
            lblTitle.ForeColor = ColorTranslator.FromHtml("#1E3B1A");
            lblSub.ForeColor = ColorTranslator.FromHtml("#4A7A3F");
        }
        else
        {
            this.BackColor = Color.White;
            lblTitle.ForeColor = Color.FromArgb(34, 34, 34);
            lblSub.ForeColor = Color.FromArgb(119, 119, 119);
        }
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

        using (SolidBrush brush = new SolidBrush(BackColor))
            g.FillPath(brush, path);

        Color borderColor = _selected
            ? ColorTranslator.FromHtml("#2D5227")
            : ColorTranslator.FromHtml("#D4DDD3");

        using (Pen pen = new Pen(borderColor, _selected ? 1.5f : 1f))
            g.DrawPath(pen, path);

        this.Region = new Region(path);
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // RoleCard
            // 
            this.Name = "RoleCard";
            this.Load += new System.EventHandler(this.RoleCard_Load);
            this.ResumeLayout(false);

    }

    private void RoleCard_Load(object sender, EventArgs e)
    {

    }
}