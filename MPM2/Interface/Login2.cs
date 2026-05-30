using MPM2.Business;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MPM2.Interface
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += Login_Load;

            ButtonSignIn.MouseEnter += (s, e) => ButtonSignIn.BackColor = ColorTranslator.FromHtml("#1E3B1A");
            ButtonSignIn.MouseLeave += (s, e) => ButtonSignIn.BackColor = ColorTranslator.FromHtml("#2D5227");
        }

        private void Login_Load(object sender, EventArgs e)
        {
               label4.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + " | East Boom CHC | KwaZulu Natal Province";

            // Load icons
            try
            {
                string iconPath = @"C:\Users\leseg\source\repos\MPM2-EBCHC\MPM2\bin\Debug\icons\";

                roleDoctor.Icon = ResizeImage(Image.FromFile(iconPath + "stethoscope.png"), 30, 30);
                roleNurse.Icon = ResizeImage(Image.FromFile(iconPath + "monitor.png"), 30, 30);
                rolePatient.Icon = ResizeImage(Image.FromFile(iconPath + "calendar.png"), 30, 30);
                roleAdmin.Icon = ResizeImage(Image.FromFile(iconPath + "settings.png"), 30, 30);

                roleDoctor.Refresh();
                roleNurse.Refresh();
                rolePatient.Refresh();
                roleAdmin.Refresh();

                // Set Doctor selected by default
                roleDoctor.Selected = true;

                // Wire card click events
                roleDoctor.CardClicked += RoleCard_Clicked;
                roleNurse.CardClicked += RoleCard_Clicked;
                rolePatient.CardClicked += RoleCard_Clicked;
                roleAdmin.CardClicked += RoleCard_Clicked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Icon error: " + ex.Message);
            }
        }

        private void RoleCard_Clicked(object sender, EventArgs e)
        {
            // Deselect all cards
            foreach (var card in new[] { roleDoctor, roleNurse, rolePatient, roleAdmin })
                card.Selected = false;

            // Select the clicked card
            RoleCard clicked = (RoleCard)sender;
            clicked.Selected = true;
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resized;
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            RegPatientForm2 reg = new RegPatientForm2();
            reg.Show();
            this.Hide();
        }
    }
}