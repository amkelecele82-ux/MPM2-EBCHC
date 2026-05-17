using MPM2.Business;
using MPM2.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2
{
    public partial class MainForm : Form
    {
        //These are added so that we can pass the user information from the login form to other forms
        public string CurrentUserName { get; set; }
        public string CurrentFullName { get; set; }
        public string CurrentRole { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = menuStrip1;
            //DashboardForm1 d = new DashboardForm1();
            LoginForm1 l = new LoginForm1();
            formSetup(l);
        }
        public void formSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null) 
            { 
                this.ActiveMdiChild.Close();
            }
            //ChildForm childForm = new ChildForm(myForm);
            //change has been done
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void npbutton_Click(object sender, EventArgs e)
        {
            PatientForm1 p = new PatientForm1();
            formSetup(p);
        }

        private void nabutton_Click(object sender, EventArgs e)
        {
            AppointmentForm1 a = new AppointmentForm1();
            formSetup(a);
        }

        private void tmpanel_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("test");
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatientForm1 p = new PatientForm1();
            formSetup(p);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegPatientForm r = new RegPatientForm();
            formSetup(r);
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentForm1 a =    new AppointmentForm1();
            formSetup(a);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm1 d = new DashboardForm1(CurrentUserName, CurrentFullName, CurrentRole);
            formSetup(d);
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentForm1 a = new AppointmentForm1();
            formSetup(a);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            formSetup(loginForm1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
