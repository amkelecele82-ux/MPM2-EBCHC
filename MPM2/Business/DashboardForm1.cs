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
        int medid;
        public DashboardForm1(string role,DataRow datarow)
        {
            InitializeComponent();
            this.userName = datarow["Username"].ToString();
            //this.fullName = fullName;
            this.fullName = datarow["FullName"].ToString();
            this.role = role;
            
            patientTableAdapter1.Fill(dataSet11.Patient);

            if (role.Equals("Nurse")) {
                DashPresbutton.Text = "Administration";
                this.medid = Convert.ToInt32(datarow["NurseID"]);
            }
            else if (role.Equals("Doctor"))
                {
                    this.medid = Convert.ToInt32(datarow["DoctorID"]);
            }
        }

        private void DashboardForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.dataSet11.Appointment);
            // TODO: This line of code loads data into the 'dataSet11.AppointmentView' table. You can move, or remove it, as needed.
            if(role.Equals("Doctor"))
            {
                this.appointmentViewTableAdapter.FillByNameFilterByTodaysDate(this.dataSet11.AppointmentView, DateTime.Today,medid);
                dgvWidgetAppointment.Columns["DoctorName"].Visible = false;
            }
            else
            {
                this.appointmentViewTableAdapter.FillByDateNurse(this.dataSet11.AppointmentView, DateTime.Today, medid);
                dgvWidgetAppointment.Columns["NurseName"].Visible = false;
            }
                medicationAdministrationTableAdapter1.Fill(dataSet11.MedicationAdministration);
            fullNameLabel.Text = fullName;
            lblRegPatient.Text = dataSet11.Patient.Count.ToString();
            Dashlabel.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + " | East Boom CHC | KwaZulu Natal Province";
            Dashlabel2.Text = DateTime.Now.ToString("HH:mm MMMM yyyy");


            int patientToday = 0;
            int missedToday = 0;
            int cancelledToday = 0;
            int appointmentcount = 0;

            DateTime today = DateTime.Today;

            foreach (DataRow appointment in dataSet11.Appointment.Rows)
            {
                DateTime appointmentDate =
                    Convert.ToDateTime(appointment["Appointment_Date"]);

                if (appointmentDate.Date == today)
                {
                    patientToday++;

                    string status = appointment["Appointment_Status"].ToString();

                    if (status.Equals("No Show"))
                        missedToday++;

                    if (status == "Cancelled")
                        cancelledToday++;
                }
                if (this.MdiParent is MainForm mf)
                {
                    if (role.Equals("Doctor"))
                    {
                        if (mf.CurrentDataRow["DoctorID"].ToString() == appointment["Doctor_ID"].ToString())
                        {
                            appointmentcount++;
                        }
                    }
                    else if (role.Equals("Nurse"))
                    {
                        if (mf.CurrentDataRow["NurseID"].ToString() == appointment["Nurse_ID"].ToString())
                        {
                            appointmentcount++;
                        }
                    }
                }
            }
            string zero = "";
            string zero2 = "";
            if (patientToday >= 0 && patientToday < 10) {
                zero = "0";
            }
            if (appointmentcount >= 0 && appointmentcount < 10)
            {
                zero2 = "0";
            }
            lblPatientToday.Text = zero + patientToday.ToString();
            lblMissedAppointment.Text = missedToday.ToString();
            lblCancelledAppointment.Text = cancelledToday.ToString();
            lblAppointmentCount.Text = zero2 + appointmentcount.ToString();

            int missedMed = 0;
            foreach (DataRow ma in dataSet11.MedicationAdministration.Rows)
            {
                if (ma["status"].ToString() =="Missed")
                {
                    missedMed++;
                }
            }
            lblMissedMed.Text = missedMed.ToString();
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

        private void DashPresbutton_Click(object sender, EventArgs e)
        {
            if (role.Equals("Doctor")) {
            PrescriptionForm pf = new PrescriptionForm();
            pf.MdiParent = this.MdiParent;
            pf.WindowState = FormWindowState.Maximized;
            pf.FormBorderStyle = FormBorderStyle.None;
            pf.Show();
            }
            else if (role.Equals("Nurse"))
                {
                    MedicationAdministrationForm maf = new MedicationAdministrationForm();
                    maf.MdiParent = this.MdiParent;
                    maf.WindowState = FormWindowState.Maximized;
                    maf.FormBorderStyle = FormBorderStyle.None;
                    maf.Show();
            }
        }

        private void lblPatientToday_Click(object sender, EventArgs e)
        {

        }
    }
}
