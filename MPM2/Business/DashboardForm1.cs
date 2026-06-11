using MPM2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
//For rounded corners
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void RefreshFullyBookedDoctorsUI()
        {
            BuildFullyBookedDoctors();
            BindFullyBookedDoctorsList();
            LoadNAPanelFullyBookedDoctors(role,medid);
        }
        public void BindFullyBookedDoctorsList()
        {
            listBoxFullyBookedDoctors.DataSource = dataSet11.FullyBookedDoctors;
            listBoxFullyBookedDoctors.DisplayMember = "DoctorName";
            listBoxFullyBookedDoctors.ValueMember = "DoctorID";
        }
        private void DashboardForm1_Load(object sender, EventArgs e)
        {
            // Fill dataset first
            this.newAppointmentsTableAdapter.Fill(this.dataSet11.NewApointments);

            // NOW assign datasource ONCE
            if (role == "Doctor")
            {
                ApplyDoctorFilter(); // this will set filtered BindingSource
            }
            else
            {
                dgvWidgetAppointment.DataSource = dataSet11.NewApointments;
            }
            if (role == "Nurse")
            {
                ApplyNurseFilter();
            }

            // Continue normal fills
            this.appointmentTableAdapter.Fill(this.dataSet11.Appointment);
            this.pro_AppointmentTableAdapter1.Fill(this.dataSet11.Pro_Appointment);
            dataSet11.FullyBookedDoctors.Clear();
           this.doctorTableAdapter1.Fill(this.dataSet11.Doctor);
            BuildFullyBookedDoctors();
            BindFullyBookedDoctorsList();
            LoadNAPanelFullyBookedDoctors(role, medid);

            if (role.Equals("Doctor"))
            {
                dgvWidgetAppointment.Columns["DoctorName"].Visible = false;
                this.customMedAdmTableAdapter1.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);
            }
            else
            {
                this.appointmentViewTableAdapter.FillByDateNurse(this.dataSet11.AppointmentView, medid, DateTime.Today);
                dgvWidgetAppointment.Columns["NurseName"].Visible = false;
            }

            medicationAdministrationTableAdapter1.Fill(dataSet11.MedicationAdministration);

            fullNameLabel.Text = fullName;
            UpdateAppointmentStatusCounts();
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
        private void ApplyDoctorFilter()
        {
            if (role != "Doctor")
                return;

            BindingSource bs = new BindingSource();
            bs.DataSource = dataSet11.NewApointments;

            string doctorName = fullName.Replace("'", "''");

            bs.Filter = $"DoctorName = '{doctorName}'";

            dgvWidgetAppointment.DataSource = bs;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }
        public void BuildFullyBookedDoctors()
        {
            dataSet11.FullyBookedDoctors.Clear();

            DateTime today = DateTime.Today;

            var grouped = dataSet11.Pro_Appointment.AsEnumerable()
                .Where(r => Convert.ToDateTime(r["AppointmentDate"]).Date == today)
                .GroupBy(r => r["DoctorID"]);

            foreach (var group in grouped)
            {
                int doctorId = Convert.ToInt32(group.Key);
                int count = group.Count();

                if (count >= 6) // fully booked rule
                {
                    var doctorRow = dataSet11.Doctor.AsEnumerable()
                        .FirstOrDefault(d => Convert.ToInt32(d["DoctorID"]) == doctorId);

                    string doctorName = doctorRow != null
                        ? doctorRow["FullName"].ToString()
                        : "Unknown";

                    // ✅ CREATE NEW ROW (THIS IS THE CORRECT PART)
                    DataRow dr = dataSet11.FullyBookedDoctors.NewRow();

                    dr["DoctorID"] = doctorId;
                    dr["DoctorName"] = doctorName;
                    dr["AppointmentCount"] = count;
                    dr["BookingDate"] = today;

                    // ✅ ADD TO TABLE
                    dataSet11.FullyBookedDoctors.Rows.Add(dr);
                }
            }
        }
        //DataTable doctorDisplayTable = new DataTable();

        private void NAPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void BuildDoctorDisplayTable()
         {
             doctorDisplayTable.Clear();

             foreach (DataRow dr in dataSet1.Doctor.Rows)
             {
                 int doctorId = Convert.ToInt32(dr["DoctorID"]);
                 string name = dr["FullName"].ToString();

                 bool isFullyBooked = dataSet1.FullyBookedDoctors.AsEnumerable()
                     .Any(r => Convert.ToInt32(r["DoctorID"]) == doctorId);

                 string displayName = isFullyBooked
                     ? name + " (FULLY BOOKED)"
                     : name;

                 DataRow newRow = doctorDisplayTable.NewRow();
                 newRow["DoctorID"] = doctorId;
                 newRow["DisplayName"] = displayName;

                 doctorDisplayTable.Rows.Add(newRow);
             }
         }
     }
        */
        public void LoadNAPanelFullyBookedDoctors(string role, int doctorId = 0)
        {
            if (role == "Doctor")
            {
                listBoxFullyBookedDoctors.DataSource = null;

                lblDisplayFullyBooked.Text = "";

                int count = dataSet11.Pro_Appointment.AsEnumerable()
                    .Count(r =>
                        Convert.ToInt32(r["DoctorID"]) == doctorId &&
                        Convert.ToDateTime(r["AppointmentDate"]).Date == DateTime.Today);

                lblNumberOfAppointments.Text =  count+"\n Appointments \nFor Today";
                lblNumberOfAppointments.Visible = true;

                return;
            }

            if (role == "Admin")
            {
                lblNumberOfAppointments.Text="";

                var names = dataSet11.FullyBookedDoctors
                    .AsEnumerable()
                    .Select(r => r["DoctorName"].ToString())
                    .ToList();

                lblDisplayFullyBooked.Text = "Fully Booked Doctors Today: " + names.Count;

                listBoxFullyBookedDoctors.DataSource = names;
            }
        }

        private void lblNAFullYBookedDoctors_Click(object sender, EventArgs e)
        {

        }

        private void lblNumberOfAppointments_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           // Report r = new Report();
            //r.Show();
        }

        private void lblCompletedAppointment_Click(object sender, EventArgs e)
        {

        }

        private void lblScheduledAppointment_Click(object sender, EventArgs e)
        {

        }

        private void lblCancelledAppointment_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        public void UpdateAppointmentStatusCounts()
        {
            if (dataSet11 == null || dataSet11.Pro_Appointment == null)
                return;

            DateTime today = DateTime.Today;

            // Start with today's appointments only
            IEnumerable<DataRow> rows = dataSet11.Pro_Appointment.AsEnumerable()
                .Where(r => Convert.ToDateTime(r["AppointmentDate"]).Date == today);

            // ROLE FILTER
            if (role == "Doctor")
            {
                rows = rows.Where(r => Convert.ToInt32(r["DoctorID"]) == medid);
            }
            else if (role == "Nurse")
            {
                rows = rows.Where(r => Convert.ToInt32(r["NurseID"]) == medid);
            }
            // Admin = no filter (sees all)

            // -------------------------
            // COMPLETED
            // -------------------------
            int completed = rows.Count(r =>
                r["AppointmentStatus"] != DBNull.Value &&
                r["AppointmentStatus"].ToString().Equals("Completed", StringComparison.OrdinalIgnoreCase));

            lblCompletedAppointment.Text = completed.ToString();

            // -------------------------
            // SCHEDULED
            // -------------------------
            int scheduled = rows.Count(r =>
                r["AppointmentStatus"] != DBNull.Value &&
                r["AppointmentStatus"].ToString().Equals("Scheduled", StringComparison.OrdinalIgnoreCase));

            lblScheduledAppointment.Text = scheduled.ToString();

            // -------------------------
            // CANCELLED
            // -------------------------
            int cancelled = rows.Count(r =>
                r["AppointmentStatus"] != DBNull.Value &&
                r["AppointmentStatus"].ToString().Equals("Cancelled", StringComparison.OrdinalIgnoreCase));

            lblCancelledAppointment.Text = cancelled.ToString();
        }
        private void ApplyNurseFilter()
        {
            if (role != "Nurse")
                return;

            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataSet11.NewApointments;

                // Use logged-in nurse full name for filtering
                string nurseName = fullName.Replace("'", "''");

                bs.Filter = $"NurseName = '{nurseName}'";

                dgvWidgetAppointment.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nurse filter error: " + ex.Message);
            }
        }
    }
    }
