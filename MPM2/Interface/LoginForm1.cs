using MPM2.Business;
using MPM2.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MPM2.Interface
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
            CBRole.Items.Add("Doctor");
            CBRole.Items.Add("Nurse");
            CBRole.Items.Add("Patient");
            CBRole.SelectedIndex = 0;

            patientTableAdapter1.Fill(dataSet11.Patient);
            doctorTableAdapter1.Fill(dataSet11.Doctor);
            nurseTableAdapter1.Fill(dataSet11.Nurse);
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (CBRole.SelectedIndex == 0)
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
                        string userName = row["Username"].ToString();
                        string fullName = row["FullName"].ToString();
                        string role = "Doctor";
                        DashboardForm1 d = new DashboardForm1(userName, fullName, role);
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        d.Show();
                        if (this.MdiParent is MainForm mf)
                        {
                            mf.CurrentUserName = userName;
                            mf.CurrentFullName = fullName;
                            mf.CurrentRole = role;
                        }
                        break;
                    }

                }
                //MessageBox.Show("Please fill in details");

            }
            else if (CBRole.SelectedIndex == 1)
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
                        string userName = row["Username"].ToString();
                        string fullName = row["FullName"].ToString();
                        string role = "Nurse";
                        DashboardForm1 d = new DashboardForm1(userName, fullName, role);
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        d.Show();
                        break;
                    }
                }
                //MessageBox.Show("Please fill in details");

            }
            else if (CBRole.SelectedIndex == 2)
            {
                foreach (DataRow row in dataSet11.Patient.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());
                        break;
                    }
                }
                //MessageBox.Show("Please fill in details");
            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

        }

        private void WebButton_Click(object sender, EventArgs e)
        {
            string googleSitesUrl = "https://sites.google.com/view/eastboomchcmanual";

            try
            {
                // 2. This command opens the link in the computer's default web browser
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = googleSitesUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // 3. This catches errors, like if the computer doesn't have a web browser installed
                MessageBox.Show("Could not open the help manual. Please check your internet connection.",
                                "Help Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
