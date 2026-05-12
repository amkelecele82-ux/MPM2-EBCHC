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

namespace MPM2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = menuStrip1;
            DashboardForm1 d = new DashboardForm1();
            formSetup(d);
        }
        public void formSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null) 
            { 
                this.ActiveMdiChild.Close();
            }
            //ChildForm childForm = new ChildForm(myForm);
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
    }
}
