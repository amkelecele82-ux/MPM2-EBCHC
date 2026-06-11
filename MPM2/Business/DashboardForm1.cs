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

            this.pro_AppointmentTableAdapter1.Fill(this.dataSet11.Pro_Appointment);

            if (role.Equals("Doctor"))
            {
                //this.appointmentViewTableAdapter.FillByNameFilterByTodaysDate(this.dataSet11.AppointmentView, DateTime.Today, medid);
                dgvWidgetAppointment.Columns["DoctorName"].Visible = false;
                this.customMedAdmTableAdapter1.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);
            }
            else
            {
                this.appointmentViewTableAdapter.FillByDateNurse(this.dataSet11.AppointmentView, medid,DateTime.Today);
                dgvWidgetAppointment.Columns["NurseName"].Visible = false;
                lblRPATitle.Text = "Recent Medicine Administration";
                lblRPATime.Text = "Date Administered: ";
            }
            medicationAdministrationTableAdapter1.Fill(dataSet11.MedicationAdministration);
            fullNameLabel.Text = fullName;
            Dashlabel.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + " | East Boom CHC | KwaZulu Natal Province";
            Dashlabel2.Text = DateTime.Now.ToString("HH:mm MMMM yyyy");


            int missedToday = 0;
            int cancelledToday = 0;

            int appointmentcount = 0;
            int appointmentcompletecount = 0;
            int appointmentremaincount = 0;
            DateTime estimateTime;

            DateTime today = DateTime.Today;

            int adminappointmentcount = 0; 
            int adminappointmentcompletecount = 0;
            int adminappointmentcancelcount = 0;
            int adminappointmentmissedcount = 0;

            foreach (DataRow appointment in dataSet11.Pro_Appointment.Rows)
            {
                //Notification widgets
                DateTime appointmentDate =
                    Convert.ToDateTime(appointment["AppointmentDate"]);

                if (appointmentDate.Date == today && role.Equals("Doctor") && Convert.ToInt32(appointment["DoctorID"]) == medid)
                {


                    string status = appointment["AppointmentStatus"].ToString();
                    if (status == "Completed" || status == "Scheduled")
                    {
                        appointmentcount++;
                    }
                    if (status.Equals("No Show")) {
                        missedToday++;
                    }
                    if (status == "Cancelled")
                    {
                        cancelledToday++;
                    }
                    if (status == "Completed")
                    {
                        appointmentcompletecount++;
                    }
                    //Current Appointment Widget
                    DateTime date = appointmentDate.Date;
                    DateTime currentTime = DateTime.Now;
                    string timeSlot = appointment["TimeSlots"].ToString();

                    var times = ParseTimeSlot(timeSlot, appointmentDate);

                    DateTime startDateTime = times.start;
                    DateTime endDateTime = times.end;


                    if (status == "Scheduled" && startDateTime >= DateTime.Now)
                    {
                        appointmentremaincount++;
                    }

                    if (currentTime >= startDateTime && currentTime <= endDateTime)
                    {

                        var patientRow = dataSet11.Patient.Rows
                                        .Cast<DataRow>()
                                        .FirstOrDefault(r => r["PatientID"].ToString() == appointment["Patient_ID"].ToString());

                        if (patientRow != null)
                            lblCAPatient.Text = "Patient: " + patientRow["FullName"].ToString();

                        if (role == "Doctor")
                        {
                            var nurseRow = dataSet11.Nurse.Rows
                                .Cast<DataRow>()
                                .FirstOrDefault(r => r["NurseID"].ToString() == appointment["Nurse_ID"].ToString());


                            if (nurseRow != null)
                                lblCAMedStaff.Text = "Nurse: " + nurseRow["FullName"].ToString();
                            lblCATime.Text = "Time: " +appointment["TimeSlots"].ToString();
                        }
                    }
                }
                else if(appointmentDate.Date == today && role == "Nurse" && Convert.ToInt32(appointment["NurseID"]) == medid)
                {
                    string status = appointment["AppointmentStatus"].ToString();
                    if (status == "Completed" || status == "Scheduled")
                    {
                        appointmentcount++;
                    }
                    if (status.Equals("No Show"))
                    {
                        missedToday++;
                    }
                    if (status == "Cancelled")
                    {
                        cancelledToday++;
                    }
                    if (status == "Completed")
                    {
                        appointmentcompletecount++;
                    }

                    //Current Appointment Widget
                    DateTime date = appointmentDate.Date;
                    DateTime currentTime = DateTime.Now;
                    string timeSlot = appointment["TimeSlots"].ToString();

                    var times = ParseTimeSlot(timeSlot, appointmentDate);

                    DateTime startDateTime = times.start;
                    DateTime endDateTime = times.end;



                    if (status == "Scheduled" && startDateTime >= DateTime.Now)
                    {
                        appointmentremaincount++;
                    }

                    if (currentTime >= startDateTime && currentTime <= endDateTime)
                    {
                        var patientRow = dataSet11.Patient.Rows
                                        .Cast<DataRow>()
                                        .FirstOrDefault(r => r["PatientID"].ToString() == appointment["Patient_ID"].ToString());

                        if (patientRow != null)
                            lblCAPatient.Text = "Patient: " + patientRow["FullName"].ToString();

                        var doctorRow = dataSet11.Doctor.Rows
                            .Cast<DataRow>()
                            .FirstOrDefault(r => r["DoctorID"].ToString() == appointment["Doctor_ID"].ToString());
                        if (doctorRow != null)
                            lblCAMedStaff.Text = "Doctor: " + doctorRow["FullName"].ToString();
                        lblCATime.Text = "Time: " + appointment["TimeSlots"].ToString();
                    }
                }

                //Administrators appointments
               if (appointmentDate.Date == today && role == "Admin") { 
                    adminappointmentcount++;
                    string status = appointment["Appointment_Status"].ToString();
                    if (status == "Completed")
                    {
                        adminappointmentcompletecount++;
                    }
                    if (status == "Cancelled")
                    {
                        adminappointmentcancelcount++;
                    }
                    if (status == "No Show")
                    {
                        adminappointmentmissedcount++;
                    }
               }
            }

            if(role == "Admin")
            {
                lblCAPatient.Text = "Total Appointments: " + adminappointmentcount;
                lblCAMedStaff.Text = "Completed: " + adminappointmentcompletecount;
                lblCATime.Text = "Missed: " + adminappointmentmissedcount.ToString();
            }
            lblWTCompleted.Text = "Completed: " + appointmentcompletecount+"/"+appointmentcount;
            lblWTRemaining.Text ="Remaining: "+appointmentremaincount+"/"+appointmentcount;
            lblCompletedAppointment.Text = appointmentcompletecount.ToString();

            var latestAppointment = dataSet11.Pro_Appointment.AsEnumerable()
                .Where(r =>
                    Convert.ToDateTime(r["AppointmentDate"]).Date == DateTime.Today &&
                    (
                        (role == "Doctor" && Convert.ToInt32(r["DoctorID"]) == medid) ||
                        (role == "Nurse" && Convert.ToInt32(r["NurseID"]) == medid)
                    ) &&
                    r["AppointmentStatus"].ToString() != "Cancelled" &&
                    r["AppointmentStatus"].ToString() != "No Show")
                .OrderByDescending(r =>
                {
                    DateTime date = Convert.ToDateTime(r["AppointmentDate"]);
                    string timeSlot = r["TimeSlots"].ToString();

                    var times = ParseTimeSlot(timeSlot, date);

                    return times.end; // ✅ use parsed END time
                })
                .FirstOrDefault();
  
            if (latestAppointment != null)
            {
                DateTime date = Convert.ToDateTime(latestAppointment["AppointmentDate"]);
                string timeSlot = latestAppointment["TimeSlots"].ToString();

                var times = ParseTimeSlot(timeSlot, date);

                DateTime finishTime = times.end;

                lblWTTime.Text = $"Estimated Finish Time: {finishTime:HH:mm}";
            }

            // Recent Prescription Activity Widget
            var latestRow = dataSet11.CustomMedAdm.AsEnumerable()
                .Where(r => r.Field<string>("status") == "Completed")
                .OrderByDescending(r => Convert.ToDateTime(r["DateIssued"])
)
                .FirstOrDefault();
            if (latestRow != null)
            {
                
                string patient = latestRow["PatientName"].ToString();
                string medicine = latestRow["MedicineName"].ToString();
                DateTime time = latestRow.Field<DateTime>("Admnistered_at");
                lblRPAPatient.Text = $"Completed: {patient}";
                lblRPAMedicine.Text = $"Prescribed Medication: {medicine}";
                lblRPATime.Text = $"Date Issued: {time:dd MMMM yyyy}";
            }

            string zero2 = "";
            if (appointmentcount >= 0 && appointmentcount < 10)
            {
                zero2 = "0";
            }
            lblMissedAppointment.Text = missedToday.ToString();
            lblCancelledAppointment.Text = cancelledToday.ToString();


            //Next Appointment
            string patientName = "No Patient";
            string appointmentTime = "No Time";
            string minutes = "Starts In: N/A";
            for (int i = 0; i < dgvWidgetAppointment.Rows.Count; i++)
            {

                string status = dgvWidgetAppointment.Rows[i].Cells["appointmentStatusDataGridViewTextBoxColumn"]?.Value?.ToString();

                if (status == "Scheduled")
                {
                    patientName = dgvWidgetAppointment.Rows[i].Cells["PatientName"].Value.ToString();
                    appointmentTime = dgvWidgetAppointment.Rows[i].Cells["timeSlotsDataGridViewTextBoxColumn"].Value.ToString();

                    string timeSlot = dgvWidgetAppointment.Rows[i]
                        .Cells["timeSlotsDataGridViewTextBoxColumn"].Value.ToString();

                    var times = ParseTimeSlot(timeSlot, DateTime.Today);

                    DateTime nextAppointmentDateTime = times.start;

                    DateTime now = DateTime.Now;

                    TimeSpan difference = nextAppointmentDateTime - now;

                    int minutesLeft = (int)Math.Max(0, difference.TotalMinutes);

                    minutes = $"Starts in {minutesLeft} minutes";
                    lblNAPatient.Text = "Patient: " + patientName;
                    lblNATime.Text = "Time: " + appointmentTime;
                    lblNAMinutes.Text = minutes;
                    break;
                }

            }
        }
        private (DateTime start, DateTime end) ParseTimeSlot(string timeSlot, DateTime date)
        {
            try
            {
                string[] parts = timeSlot.Split('-');

                string startStr = parts[0].Trim();
                string endStr = parts[1].Trim();

                DateTime start = DateTime.ParseExact(startStr, "hh:mm tt", null);
                DateTime end = DateTime.ParseExact(endStr, "hh:mm tt", null);
                start = date.Date.Add(start.TimeOfDay);
                end = date.Date.Add(end.TimeOfDay);

                return (start, end);
            }
            catch
            {
                return (DateTime.MinValue, DateTime.MinValue);
            }
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
           AdminAppointment a = new AdminAppointment();
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
           AdminAppointment a = new AdminAppointment();
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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void CAPanel_MouseEnter(object sender, EventArgs e)
        {
            
            
            CASubpanel.BackColor = Color.FromArgb(27, 94, 53);
            CAPanel.BackColor = Color.WhiteSmoke;
        }

        private void CAPanel_MouseLeave(object sender, EventArgs e)
        {
            CASubpanel.BackColor = Color.FromArgb(188, 135, 38);
            CAPanel.BackColor = Color.White;
        }

        private void WTPanel_MouseLeave(object sender, EventArgs e)
        {
            WTSubpanel.BackColor = Color.FromArgb(36, 92, 146);
            WTPanel.BackColor = Color.White;
        }

        private void RPAPanel_MouseEnter(object sender, EventArgs e)
        {
            RPASubpanel.BackColor = Color.FromArgb(27, 94, 53);
            RPAPanel.BackColor = Color.WhiteSmoke;
        }

        private void RPAPanel_MouseLeave(object sender, EventArgs e)
        {
            RPASubpanel.BackColor = Color.FromArgb(202, 83, 85);
            RPAPanel.BackColor = Color.White;
        }

        private void NAPanel_MouseEnter(object sender, EventArgs e)
        {
            NASubpanel.BackColor = Color.FromArgb(27, 94, 53);
            NAPanel.BackColor = Color.WhiteSmoke;
        }

        private void NAPanel_MouseLeave(object sender, EventArgs e)
        {
            NASubpanel.BackColor = Color.FromArgb(192, 0, 0);
            NAPanel.BackColor = Color.White;
        }

        private void WTPanel_MouseEnter(object sender, EventArgs e)
        {
            WTSubpanel.BackColor = Color.FromArgb(27, 94, 53);
            WTPanel.BackColor = Color.WhiteSmoke;
        }
    }
}
