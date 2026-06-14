using MPM2.Business;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MPM2.Interface
{
    public partial class Login2 : Form
    {
        int roleSelection;
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
            this.doctorTableAdapter1.Fill(this.dataSet11.Doctor);
            this.nurseTableAdapter1.Fill(this.dataSet11.Nurse);
            this.administratorTableAdapter1.Fill(this.dataSet11.Administrator);


            label4.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + " | East Boom CHC | KwaZulu Natal Province";

            // Load icons
            try
            {
                string basePath = Path.Combine(Application.StartupPath, "Resources", "LoginIcons", "Icons");

                roleDoctor.Icon = ResizeImage(Image.FromFile(Path.Combine(basePath, "stethoscope.png")), 30, 30);
                roleNurse.Icon = ResizeImage(Image.FromFile(Path.Combine(basePath, "monitor.png")), 30, 30);
             //   rolePatient.Icon = ResizeImage(Image.FromFile(Path.Combine(basePath, "calendar.png")), 30, 30);
                roleAdmin.Icon = ResizeImage(Image.FromFile(Path.Combine(basePath, "settings.png")), 30, 30);

                roleDoctor.Refresh();
                roleNurse.Refresh();
               // rolePatient.Refresh();
                roleAdmin.Refresh();

                // Set Doctor selected by default
                roleDoctor.Selected = true;
                roleSelection = 0;

                // Wire card click events
                roleDoctor.CardClicked += RoleCard_Clicked;
                roleNurse.CardClicked += RoleCard_Clicked;
            //    rolePatient.CardClicked += RoleCard_Clicked;
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
            foreach (var card in new[] { roleDoctor, roleNurse, roleAdmin })
                card.Selected = false;

            // Select the clicked card
            RoleCard clicked = (RoleCard)sender;
            clicked.Selected = true;


            if (clicked == roleDoctor)
                roleSelection = 0;
            else if (clicked == roleNurse)
                roleSelection = 1;
            else if (clicked == roleAdmin)
                roleSelection = 2;
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
            Boolean accessed = false;
            if (roleSelection == 0)
            {

                foreach (DataRow row in dataSet11.Doctor.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text.ToString()) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());
                        if (this.ActiveMdiChild != null)
                        {
                            this.ActiveMdiChild.Close();
                        }
                        string role = "Doctor";
                        DataRow dataRow = row;
                        if (this.MdiParent is MainForm mf)
                        {
                            mf.CurrentRole = role;
                            mf.CurrentDataRow = row;
                            mf.enableMenuItems();
                        }
                        DashboardForm1 d = new DashboardForm1(role, dataRow);
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        d.Show();

                        accessed = true;
                        break;
                    }

                }
                if (!accessed)
                {
                    MessageBox.Show("Incorrect doctor login details");
                }

            }
            else if (roleSelection == 1)
            {

                foreach (DataRow row in dataSet11.Nurse.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());
                        if (this.ActiveMdiChild != null)
                        {
                            this.ActiveMdiChild.Close();
                        }

                        string role = "Nurse";
                        DashboardForm1 d = new DashboardForm1(role, row);
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        if (this.MdiParent is MainForm mf)
                        {
                            mf.CurrentRole = role;
                            mf.CurrentDataRow = row;
                            mf.enableMenuItems();
                        }
                        d.Show();
                        accessed = true;
                        break;
                    }
                }
                if (!accessed)
                {
                    MessageBox.Show("Incorrect nurse login details");
                }

            }
            else if (roleSelection == 2)
            {
                foreach (DataRow row in dataSet11.Administrator.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());
                        accessed = true;
                        string role = "Administrator";
                        DashboardForm1 d = new DashboardForm1(role, row);
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        if (this.MdiParent is MainForm mf)
                        {
                            mf.CurrentRole = "Administrator";
                            mf.CurrentDataRow = row;
                            mf.enableMenuItems();
                        }
                        d.Show();
                        break;
                    }
                }
                if (!accessed)
                {
                    MessageBox.Show("Incorrect administrator login details");
                }
            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void rolePatient_Load(object sender, EventArgs e)
        {

        }

        private void roleAdmin_Load(object sender, EventArgs e)
        {
            roleSelection = 2;
        }

        private void roleNurse_Load(object sender, EventArgs e)
        {
            roleSelection = 1;
        }

        private void roleDoctor_Load(object sender, EventArgs e)
        {
            roleSelection = 0;
        }
    }
}