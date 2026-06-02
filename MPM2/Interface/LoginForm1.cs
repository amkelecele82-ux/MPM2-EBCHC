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
            Boolean accessed = false;
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
                    MessageBox.Show("Incorrect login details");
                }

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
                        
                        string role = "Nurse";
                        DashboardForm1 d = new DashboardForm1(role,row);
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
                    MessageBox.Show("Incorrect login details");
                }

            }
            else if (CBRole.SelectedIndex == 2)
            {
                foreach (DataRow row in dataSet11.Patient.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());
                        accessed = true;
                        PatientAppointment pa = new PatientAppointment();
                        pa.MdiParent = this.MdiParent;
                        pa.WindowState = FormWindowState.Maximized;
                        pa.FormBorderStyle = FormBorderStyle.None;
                        if (this.MdiParent is MainForm mf)
                        {
                            mf.CurrentRole = "Patient";
                            mf.CurrentDataRow = row;
                            mf.enableMenuItems();
                        }
                        pa.Show();
                        break;
                    }
                }
                if (!accessed)
                {
                    MessageBox.Show("Incorrect login details");
                }
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
