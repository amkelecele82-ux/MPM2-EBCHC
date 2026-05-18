using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//For rounded corners
using System.Drawing.Drawing2D;

namespace MPM2.Business
{
    public partial class DashboardForm1 : Form
    {
        string userName;
        string fullName;
        string role;
        public DashboardForm1(string userName, string fullName, string role)
        {
            InitializeComponent();
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
            patientTableAdapter1.Fill(dataSet11.Patient);
        }

        private void DashboardForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.AppointmentView' table. You can move, or remove it, as needed.
            this.appointmentViewTableAdapter.FillByNameFilterByTodaysDate(this.dataSet11.AppointmentView, userName);
            fullNameLabel.Text = fullName;
            lblRegPatient.Text = dataSet11.Patient.Count.ToString();
            Dashlabel.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + " | East Boom CHC | KwaZulu Natal Province";
            Dashlabel2.Text = DateTime.Now.ToString("HH:mm MMMM yyyy");
        }

        private void dgvWidgetAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashPatientbutton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            PatientForm1 p = new PatientForm1();
            p.MdiParent = this.MdiParent;
            p.WindowState = FormWindowState.Maximized;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Show();
        }

        private void DashApbutton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            AppointmentForm1 a = new AppointmentForm1();
            a.MdiParent = this.MdiParent;
            a.WindowState = FormWindowState.Maximized;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Show();
        }

        private void Dashlabel2_Click(object sender, EventArgs e)
        {

        }

        private void npbutton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            RegPatientForm rp = new RegPatientForm();
            rp.MdiParent = this.MdiParent;
            rp.WindowState = FormWindowState.Maximized;
            rp.FormBorderStyle = FormBorderStyle.None;
            rp.Show();
        }

        private void fpbutton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            PatientForm1 p = new PatientForm1();
            p.MdiParent = this.MdiParent;
            p.WindowState = FormWindowState.Maximized;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Show();
        }

        private void nabutton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            AppointmentForm1 a = new AppointmentForm1();
            a.MdiParent = this.MdiParent;
            a.WindowState = FormWindowState.Maximized;
            a.FormBorderStyle = FormBorderStyle.None;
            a.SetTab(1);
            a.Show();
        }
    }
}
