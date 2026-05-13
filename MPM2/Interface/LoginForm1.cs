using MPM2.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        DashboardForm1 d = new DashboardForm1();
                        d.MdiParent = this.MdiParent;
                        d.WindowState = FormWindowState.Maximized;
                        d.FormBorderStyle = FormBorderStyle.None;
                        d.Show();
                        break;
                    }
                    
                }
                
            }
            else if (CBRole.SelectedIndex == 1)
            {
                
                foreach (DataRow row in dataSet11.Nurse.Rows)
                {
                    if (row["Username"].ToString().Equals(TBUsername.Text) && row["Password"].ToString().Equals(TBPassword.Text))
                    {
                        MessageBox.Show("Hello " + row["FullName"].ToString());

                        break;
                    }
                }

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
            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }
    }
}
