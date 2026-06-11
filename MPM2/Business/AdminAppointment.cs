using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MPM2.Business
{
    public partial class AdminAppointment : Form
    {
        // Per-doctor booked slots: DoctorID -> (Date -> list of(start, end) TimeSpan tuples)
        private readonly Dictionary<int, Dictionary<DateTime, List<Tuple<TimeSpan, TimeSpan>>>> bookedSlotsByDoctor
            = new Dictionary<int, Dictionary<DateTime, List<Tuple<TimeSpan, TimeSpan>>>>();

        // Master list of start slot strings (e.g. "09:00 AM")
        private DashboardForm1 dashboardForm;
        
        private readonly List<string> masterTimeSlots = new List<string>();
        public AdminAppointment()
        {
            InitializeComponent();
            txtReason.MaxLength = 100;
            if (txtReason.MaxLength > 100)
            {
                MessageBox.Show(" Please ensure it is set to 100 characters.", "Initialization Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int GetLoggedInDoctorId()
        {
            if (this.MdiParent is MainForm main && main.CurrentDataRow != null && main.CurrentRole == "Doctor")
            {
                var dr = main.CurrentDataRow;
                if (dr.Table.Columns.Contains("DoctorID") && dr["DoctorID"] != DBNull.Value)
                {
                    int id;
                    if (int.TryParse(dr["DoctorID"].ToString(), out id))
                        return id;
                }
            }
            return 0;
        }
        private string GetLoggedInDoctorName()
        {
            if (this.MdiParent is MainForm main && main.CurrentDataRow != null && main.CurrentRole == "Doctor")
            {
                var dr = main.CurrentDataRow;
                if (dr.Table.Columns.Contains("FullName") && dr["FullName"] != DBNull.Value)
                {
                    return dr["FullName"].ToString();
                }
            }
            return string.Empty;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (e.Start.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "You cannot book appointments for previous dates.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                monthCalendar1.SetDate(DateTime.Today);
            }
            // LoadAvailableStartTimes(monthCalendar1.SelectionStart);

            RefreshAvailableStartTimesForSelectedDate();

        }

        private void AdminAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.vwUAppointments' table. You can move, or remove it, as needed.
            this.vwUAppointmentsTableAdapter.Fill(this.dataSet1.vwUAppointments);
            // TODO: This line of code loads data into the 'dataSet1.vwUAppointments' table. You can move, or remove it, as needed.
            this.vwUAppointmentsTableAdapter.Fill(this.dataSet1.vwUAppointments);
            // TODO: This line of code loads data into the 'dataSet11.vwUAppointments' table. You can move, or remove it, as needed.
            this.vwUAppointmentsTableAdapter.Fill(this.dataSet1.vwUAppointments);
            // TODO: This line of code loads data into the 'dataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dataSet1.Doctor);
            BindingSource doctorBS = new BindingSource();
            doctorBS.DataSource = dataSet1.Doctor;

            comboBox1DoctorName.DataSource = doctorBS;
            comboBox1DoctorName.DisplayMember = "FullName";
            comboBox1DoctorName.ValueMember = "DoctorID";
            // TODO: This line of code loads data into the 'dataSet13.NewApointments' table. You can move, or remove it, as needed.
            // this.newAppointmentsTableAdapter.Fill(this.dataSet13.NewApointments);
            // TODO: This line of code loads data into the 'dataSet12.NewApointments' table. You can move, or remove it, as needed.

          /*  AppointmentStatus.Items.Clear();
            AppointmentStatus.Items.Add("Scheduled");
            AppointmentStatus.Items.Add("Completed");
            AppointmentStatus.Items.Add("Cancelled");*/
            var col = dataGridViewInnerJoin.Columns["AppointmentStatus"] as DataGridViewComboBoxColumn;

            col.DataSource = new List<string>
{
    "Scheduled",
    "Completed",
    "Cancelled"
};

            col.DataPropertyName = "AppointmentStatus";
           // AppointmentStatus.SelectedItem = 0;
            this.newAppointmentsTableAdapter.Fill(this.dataSet1.NewApointments);

            // TODO: This line of code loads data into the 'dataSet12.Pro_Appointment' table. You can move, or remove it, as needed.
            this.pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment);
            // Fill datasets

            this.pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment);
            // this.pro_AppointmentTableAdapter.Fill(this.dataSet11.Pro_Appointment);

            // build master time slots and populate initial comboBoxSta items
            masterTimeSlots.Clear();
            DateTime start = DateTime.ParseExact("09:00", "HH:mm", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact("16:30", "HH:mm", CultureInfo.InvariantCulture);
            while (start <= end)
            {
                string text = start.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                masterTimeSlots.Add(text);
                start = start.AddMinutes(30);
            }

            // initialize selected controls
            comboBoxSta.Items.Clear();
            comboBoxSta.Items.AddRange(masterTimeSlots.ToArray());
            comboBoxSta.SelectedIndexChanged += comboBoxSta_SelectedIndexChanged;
            string doctorName = GetLoggedInDoctorName();
            if (!string.IsNullOrEmpty(doctorName))
            {
                comboBox1DoctorName.Text = doctorName;
               // txtDocto.ReadOnly = true;
            }
            else
            {
                comboBox1DoctorName.Text = string.Empty;
                //txtDoctor.ReadOnly = true;
            }

            int doctorId = GetLoggedInDoctorId();
            if (doctorId != 0)
            {
                textBoxDrID.Text = doctorId.ToString();
                textBoxDrID.ReadOnly = true;
            }
            else
            {
                textBoxDrID.Text = string.Empty;
                textBoxDrID.ReadOnly = true;
            }
            string nurseName = GetLoggedInNurseName();

            if (!string.IsNullOrWhiteSpace(nurseName))
            {
                txtNurse.Text = nurseName; // optional display
                ApplyNurseFilter();
            }

            this.newAppointmentsTableAdapter.Fill(this.dataSet1.NewApointments);
           ApplyNurseFilter();
            this.nurseTableAdapter.Fill(this.dataSet1.Nurse);
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            this.vwUAppointmentsTableAdapter.Fill(this.dataSet1.vwUAppointments);

            BindingSource vwAppointmentsBS = new BindingSource();
            vwAppointmentsBS.DataSource = dataSet1;
             vwAppointmentsBS.DataMember = "vwUAppointments";
            ApplyNurseFilter();
            ApplyDoctorFilter();
            dataGridViewInnerJoin.DataSource = vwAppointmentsBS;
            // Build in-memory booked slots per doctor from dataset so per-doctor availability is correct
            BuildBookedSlotsFromDataset();

            // Refresh combo boxes for the currently selected date and logged-in doctor
            RefreshAvailableStartTimesForSelectedDate();
           ApplyDoctorFilter();    
            // Ensure dataGridView3 shows filtered view for the logged-in role
             //ApplyRoleFilter();

            txtStatus.Text = "Scheduled";
            ApplyTabPermissions();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Basic validation FIRST
                if (comboBoxSta.SelectedItem == null || comboBoxEnd.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid start and end time.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBox1DoctorName.Text) ||
                    string.IsNullOrWhiteSpace(txtNurse.Text) ||
                    string.IsNullOrWhiteSpace(txtPatients.Text) ||
                    string.IsNullOrWhiteSpace(txtStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtReason.Text))
                {
                    MessageBox.Show("Please complete all required fields.");
                    return;
                }

                if (txtReason.Text.Length > 100)
                {
                    MessageBox.Show("Reason cannot exceed 100 characters.");
                    return;
                }

                if (dataGridView1.CurrentRow == null || dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("Please select both patient and nurse.");
                    return;
                }

                // 2. Parse times
                DateTime selectedStart = DateTime.ParseExact(comboBoxSta.SelectedItem.ToString(), "hh:mm tt", CultureInfo.InvariantCulture);
                DateTime selectedEnd = DateTime.ParseExact(comboBoxEnd.SelectedItem.ToString(), "hh:mm tt", CultureInfo.InvariantCulture);

                TimeSpan newStart = selectedStart.TimeOfDay;
                TimeSpan newEnd = selectedEnd.TimeOfDay;

                DateTime datex = monthCalendar1.SelectionStart.Date;

               int doctorId = int.Parse(textBoxDrID.Text);
              // int doctorId= int.Parse(GetLoggedInDoctorId().ToString());   
                int patientId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int nurseId = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                // 3. Block lunch time
                var blockedStart = DateTime.ParseExact("12:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
                var blockedEnd = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

                if ((newStart >= blockedStart && newStart < blockedEnd) ||
                    (newEnd > blockedStart && newEnd <= blockedEnd))
                {
                    MessageBox.Show("Appointments cannot be scheduled between 12:00 PM and 1:00 PM.");
                    return;
                }

                // 4. Daily limit check
                //int doctorIdk = Convert.ToInt32(textBoxDrID.Text);
                //DateTime datexx = monthCalendar1.SelectionStart.Date;

                // doctorId
                DateTime date = monthCalendar1.SelectionStart.Date;

                int currentCount = CountDoctorAppointmentsOnDate(doctorId, date);

                if (currentCount >= 6)
                {
                    MessageBox.Show("Doctor Fully Booked ,Will be Available Tomorrow ");
                    return;
                }
           
                // 6. ONLY NOW create dataset row
                /*var dr = dataSet1.NewApointments.NewRow();

                dr["DoctorName"] = txtDoctor.Text;
                dr["NurseName"] = txtNurse.Text;
                dr["PatientName"] = txtPatients.Text;
                dr["AppointmentStatus"] = txtStatus.Text;
                dr["AppointmentReason"] = txtReason.Text;
                dr["AppointmentDate"] = datex;
                dr["TimeSlots"] = comboBoxSta.SelectedItem + " - " + comboBoxEnd.SelectedItem;
                */
                // 7. DB insert
                string timeSlot =
    comboBoxSta.SelectedItem.ToString()
    + " - "
    + comboBoxEnd.SelectedItem.ToString();
                pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment); // ensure dataset is up-to-date before duplicate check
                if (IsDuplicateAppointment(patientId, doctorId, date, timeSlot,txtReason.Text))
                {
                    MessageBox.Show("This exact appointment already exists.",
                        "Duplicate Blocked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment);
                pro_AppointmentTableAdapter.Insert(
                    patientId,
                       doctorId,
                    nurseId,
                    txtStatus.Text,
                    txtReason.Text,
                    datex,
                    timeSlot.ToString()
                );

                // 8. UI refresh
                pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment);
                /* if (dashboardForm != null)
                 {
                     dashboardForm.BuildFullyBookedDoctors();
                     dashboardForm.BindFullyBookedDoctorsList();
                     dashboardForm.LoadNAPanelFullyBookedDoctors();
                 }
                */
             
                newAppointmentsTableAdapter.Fill(this.dataSet1.NewApointments);
                if (dashboardForm != null)
                {
                    dashboardForm.RefreshFullyBookedDoctorsUI();
                    dashboardForm.LoadNAPanelFullyBookedDoctors("Admin");

                    dashboardForm.UpdateAppointmentStatusCounts();
                }

                pro_AppointmentTableAdapter.Fill(dataSet1.Pro_Appointment);
                BuildBookedSlotsFromDataset();
                RefreshAvailableStartTimesForSelectedDate();
                MessageBox.Show("Appointment created successfully!");

               // ApplyDoctorFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating appointment: " + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }
        private void comboBoxSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSta.SelectedItem == null)
                return;

            DateTime selectedStart = DateTime.ParseExact(comboBoxSta.SelectedItem.ToString(), "hh:mm tt", CultureInfo.InvariantCulture);
            LoadAvailableEndTimesForSelectedStart(monthCalendar1.SelectionStart.Date, selectedStart.TimeOfDay);
        }



        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNurse.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPatients.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patientBindingSource.Filter = "FullName LIKE '%" + txtSP.Text + "%'";
        }

        private void comboBoxEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /* private void GetBookedTimesForDate(DateTime date, out HashSet<string> bookedStarts, out HashSet<string> bookedEnds)
         {
             bookedStarts = new HashSet<string>();
             bookedEnds = new HashSet<string>();

             if (dataSet11 == null || dataSet11.Pro_Appointment == null)
                 return;

             foreach (DataRow row in dataSet11.Pro_Appointment.Rows)
             {
                 if (row == null)
                     continue;

                 if (row.Table.Columns.Contains("AppointmentDate") && row["AppointmentDate"] != DBNull.Value)
                 {
                     DateTime apptDate;
                     try
                     {
                         apptDate = Convert.ToDateTime(row["AppointmentDate"]);
                     }
                     catch
                     {
                         continue;
                     }

                     if (apptDate.Date != date.Date)
                         continue;

                     if (!row.Table.Columns.Contains("TimeSlots") || row["TimeSlots"] == DBNull.Value)
                         continue;

                     string timeSlots = row["TimeSlots"].ToString();
                     if (string.IsNullOrWhiteSpace(timeSlots))
                         continue;

                     // Expecting format "hh:mm tt - hh:mm tt"
                     string[] parts = timeSlots.Split(new[] { '-' }, 2);
                     if (parts.Length != 2)
                         continue;

                     string s = parts[0].Trim();
                     string e = parts[1].Trim();

                     DateTime sd, ed;
                     if (DateTime.TryParseExact(s, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out sd))
                         s = sd.ToString("hh:mm tt");
                     if (DateTime.TryParseExact(e, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out ed))
                         e = ed.ToString("hh:mm tt");

                     bookedStarts.Add(s);
                     bookedEnds.Add(e);
                 }
             }
         }
        */
        /*    private void LoadAvailableStartTimes(DateTime date)
            {
                comboBoxSta.Items.Clear();
                comboBoxEnd.Items.Clear();

                HashSet<string> bookedStarts, bookedEnds;
                GetBookedTimesForDate(date, out bookedStarts, out bookedEnds);

                DateTime start = DateTime.ParseExact("09:00", "HH:mm", CultureInfo.InvariantCulture);
                DateTime end = DateTime.ParseExact("16:30", "HH:mm", CultureInfo.InvariantCulture);

                while (start <= end)
                {
                    string formatted = start.ToString("hh:mm tt");
                    if (!bookedStarts.Contains(formatted))
                    {
                        comboBoxSta.Items.Add(formatted);
                    }
                    start = start.AddMinutes(30);
                }

                if (comboBoxSta.Items.Count > 0)
                {
                    comboBoxSta.SelectedIndex = 0;
                }
                else
                {
                    comboBoxSta.Text = string.Empty;
                    comboBoxEnd.Text = string.Empty;
                }
            }
        */
        private void LoadAvailableEndTimesForSelectedStart(DateTime selectedDate, TimeSpan selectedStartTs)
        {
            comboBoxEnd.Items.Clear();

            var unavailable = new List<Tuple<TimeSpan, TimeSpan>>();

            int doctorIdToCheck = GetActiveDoctorId();

            if (doctorIdToCheck != 0)
            {
                if (bookedSlotsByDoctor.TryGetValue(doctorIdToCheck, out var dict) &&
                    dict.TryGetValue(selectedDate, out var list))
                {
                    unavailable.AddRange(list);
                }
            }

            DateTime limit = DateTime.ParseExact("16:30", "HH:mm", CultureInfo.InvariantCulture);
            DateTime next = DateTime.Today.Add(selectedStartTs).AddMinutes(30);

            var blockedStart = DateTime.ParseExact("12:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            var blockedEnd = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

            while (next.TimeOfDay <= limit.TimeOfDay)
            {
                var formatted = next.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                var ts = next.TimeOfDay;

                if (ts > blockedStart && ts <= blockedEnd)
                {
                    next = next.AddMinutes(30);
                    continue;
                }

                bool overlaps = unavailable.Any(b => !(ts <= b.Item1 || selectedStartTs >= b.Item2));
                if (!overlaps)
                    comboBoxEnd.Items.Add(formatted);

                next = next.AddMinutes(30);
            }

            if (comboBoxEnd.Items.Count > 0)
                comboBoxEnd.SelectedIndex = 0;
            else
                comboBoxEnd.Text = string.Empty;
        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ApplyDoctorFilter()
        {
            try
            {
                if (!(this.MdiParent is MainForm main))
                    return;

                // ADMIN: see everything
                if (main.CurrentRole != "Doctor")
                {
                    newApointmentsBindingSource.RemoveFilter();
                    return;
                }

                // DOCTOR: filter own appointments only
                string doctorName = comboBox1DoctorName.Text.Trim();

                if (string.IsNullOrWhiteSpace(doctorName))
                {
                    newApointmentsBindingSource.RemoveFilter();
                    return;
                }

                newApointmentsBindingSource.Filter =
                    $"DoctorName = '{doctorName.Replace("'", "''")}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
          private int CountDoctorAppointmentsOnDate(int doctorId, DateTime date)
          {
              int count = 0;

              if (dataGridViewInnerJoin == null)
                  return 0;

              foreach (DataGridViewRow row in dataGridViewInnerJoin.Rows)
              {
                  if (row.IsNewRow)
                      continue;

                  try
                  {
                      // Doctor ID (from grid)
                      int gridDoctorId =
                          Convert.ToInt32(row.Cells["DoctorID"].Value);

                      // Date (from grid)
                      DateTime gridDate =
                          Convert.ToDateTime(row.Cells["AppointmentDate"].Value);

                      if (gridDoctorId == doctorId &&
                          gridDate.Date == date.Date)
                      {
                          count++;
                      }
                  }
                  catch
                  {
                      continue;
                  }
              }

              return count;
          }
        */
        private int CountDoctorAppointmentsOnDate(int doctorId, DateTime date)
        {
            if (dataSet1 == null || dataSet1.Pro_Appointment == null) return 0; int count = 0;
            foreach (DataRow row in dataSet1.Pro_Appointment.Rows)
            {
                if (row == null) continue; if (!row.Table.Columns.Contains("DoctorID") || row["DoctorID"] == DBNull.Value) continue;
                int rowDoctorId;
                if (!int.TryParse(row["DoctorID"].ToString(), out rowDoctorId)) continue;
                if (rowDoctorId != doctorId) continue;
                if (!row.Table.Columns.Contains("AppointmentDate") || row["AppointmentDate"] == DBNull.Value) continue;
                DateTime apptDate; try { apptDate = Convert.ToDateTime(row["AppointmentDate"]); }
                catch
                {
                    continue;
                }
                if (apptDate.Date == date.Date) count++;
            }
            return count;
        }
        private void BuildBookedSlotsFromDataset()
        {
            bookedSlotsByDoctor.Clear();

            if (dataSet1?.Pro_Appointment == null)
                return;

            foreach (DataRow row in dataSet1.Pro_Appointment.Rows)
            {
                if (row == null || row.RowState == DataRowState.Deleted)
                    continue;

                if (!int.TryParse(row["DoctorID"]?.ToString(), out int doctorId))
                    continue;

                if (!DateTime.TryParse(row["AppointmentDate"]?.ToString(), out DateTime apptDate))
                    continue;

                string timeSlots = row["TimeSlots"]?.ToString();
                if (string.IsNullOrWhiteSpace(timeSlots))
                    continue;

                string[] parts = timeSlots.Split(new[] { '-' }, 2);
                if (parts.Length != 2)
                    continue;

                if (!DateTime.TryParseExact(parts[0].Trim(), "hh:mm tt",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime sd))
                    continue;

                if (!DateTime.TryParseExact(parts[1].Trim(), "hh:mm tt",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ed))
                    continue;

                if (!bookedSlotsByDoctor.ContainsKey(doctorId))
                    bookedSlotsByDoctor[doctorId] = new Dictionary<DateTime, List<Tuple<TimeSpan, TimeSpan>>>();

                if (!bookedSlotsByDoctor[doctorId].ContainsKey(apptDate.Date))
                    bookedSlotsByDoctor[doctorId][apptDate.Date] = new List<Tuple<TimeSpan, TimeSpan>>();

                bookedSlotsByDoctor[doctorId][apptDate.Date]
                    .Add(Tuple.Create(sd.TimeOfDay, ed.TimeOfDay));
            }
        }
        private void RefreshAvailableStartTimesForSelectedDate()
        {
            comboBoxSta.Items.Clear();
            comboBoxEnd.Items.Clear();

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            int doctorId = GetActiveDoctorId();

            List<Tuple<TimeSpan, TimeSpan>> unavailable = new List<Tuple<TimeSpan, TimeSpan>>();

            if (doctorId != 0 &&
                bookedSlotsByDoctor.TryGetValue(doctorId, out var dict) &&
                dict.TryGetValue(selectedDate, out var list))
            {
                unavailable = list;
            }

            TimeSpan blockedStart = TimeSpan.Parse("12:00");
            TimeSpan blockedEnd = TimeSpan.Parse("13:00");

            foreach (string slot in masterTimeSlots)
            {
                TimeSpan slotTs =
                    DateTime.ParseExact(slot, "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

                if (slotTs >= blockedStart && slotTs < blockedEnd)
                    continue;

                bool isUnavailable = unavailable.Any(b =>
                    slotTs >= b.Item1 && slotTs < b.Item2);

                if (!isUnavailable)
                    comboBoxSta.Items.Add(slot);
            }

            if (comboBoxSta.Items.Count > 0)
                comboBoxSta.SelectedIndex = 0;
            else
            {
                comboBoxSta.Text = "";
                comboBoxEnd.Text = "";
            }
        }
        private void ApplyRoleFilter()
        {
            if (!(this.MdiParent is MainForm main))
                return;

            // ADMIN: see all records
            if (main.CurrentRole == "Admin")
            {
                newApointmentsBindingSource.RemoveFilter();
                return;
            }

            // DOCTOR: see only own appointments
            if (main.CurrentRole == "Doctor")
            {
                string doctorName = GetLoggedInDoctorName();

                if (!string.IsNullOrWhiteSpace(doctorName))
                {
                    newApointmentsBindingSource.Filter =
                        $"DoctorName = '{doctorName.Replace("'", "''")}'";
                }

                return;
            }

            // NURSE: see only own appointments
            if (main.CurrentRole == "Nurse")
            {
                string nurseName = GetLoggedInNurseName();

                if (!string.IsNullOrWhiteSpace(nurseName))
                {
                    newApointmentsBindingSource.Filter =
                        $"NurseName = '{nurseName.Replace("'", "''")}'";
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private bool IsTimeSlotBooked(int doctorId, DateTime date, TimeSpan newStart, TimeSpan newEnd)
        {
            if (dataSet1 == null || dataSet1.Pro_Appointment == null)
                return false;

            foreach (DataRow row in dataSet1.Pro_Appointment.Rows)
            {
                if (row == null)
                    continue;

                if (!row.Table.Columns.Contains("DoctorID") || row["DoctorID"] == DBNull.Value)
                    continue;

                int rowDoctorId = Convert.ToInt32(row["DoctorID"]);

                if (rowDoctorId != doctorId)
                    continue;

                if (!row.Table.Columns.Contains("AppointmentDate") || row["AppointmentDate"] == DBNull.Value)
                    continue;

                DateTime rowDate = Convert.ToDateTime(row["AppointmentDate"]);

                if (rowDate.Date != date.Date)
                    continue;

                if (!row.Table.Columns.Contains("TimeSlots") || row["TimeSlots"] == DBNull.Value)
                    continue;

                string slot = row["TimeSlots"].ToString();

                string[] parts = slot.Split(new[] { '-' }, 2);
                if (parts.Length != 2)
                    continue;

                TimeSpan existingStart =
                    DateTime.ParseExact(parts[0].Trim(), "hh:mm tt", CultureInfo.InvariantCulture)
                    .TimeOfDay;

                TimeSpan existingEnd =
                    DateTime.ParseExact(parts[1].Trim(), "hh:mm tt", CultureInfo.InvariantCulture)
                    .TimeOfDay;

                // 🔥 OVERLAP CHECK (MOST IMPORTANT PART)
                bool exactMatch =
    newStart == existingStart && newEnd == existingEnd;
                bool overlap = newStart < existingEnd && newEnd > existingStart;

                if (overlap || exactMatch)
                    return true;
            }

            return false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ApplyTabPermissions()
        {
            if (!(this.MdiParent is MainForm main))
                return;

            if (main.CurrentRole == "Doctor")
            {
                // Doctor only sees TabPage3
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.SelectedTab = tabPage2;
                ApplyDoctorFilter();
            }
            else if (main.CurrentRole == "Admin")
            {
                // Admin sees everything (no change needed)
            }
        }

        private void comboBox1DoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1DoctorName.SelectedValue != null)
            {
                if (comboBox1DoctorName.SelectedValue == null)
                    return;

                int selectedDoctorId;

                if (!int.TryParse(comboBox1DoctorName.SelectedValue.ToString(), out selectedDoctorId))
                    return;

                // Check if doctor is fully booked today
                bool isFullyBooked = dataSet1.FullyBookedDoctors.AsEnumerable()
                    .Any(r => Convert.ToInt32(r["DoctorID"]) == selectedDoctorId);

                if (isFullyBooked)
                {
                    MessageBox.Show(
                        "Unable to Pick, Doctor Fully Booked For Today",
                        "Booking Blocked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    // 🔥 reset selection
                    comboBox1DoctorName.SelectedIndexChanged -= comboBox1DoctorName_SelectedIndexChanged;
                    comboBox1DoctorName.SelectedIndex = -1;
                    comboBox1DoctorName.SelectedIndexChanged += comboBox1DoctorName_SelectedIndexChanged;

                    textBoxDrID.Clear();
                    return;
                }
                textBoxDrID.Text = comboBox1DoctorName.SelectedValue.ToString();
                //textBoxDrID.Text = comboBox1DoctorName.SelectedValue.ToString();
                BuildBookedSlotsFromDataset();
                RefreshAvailableStartTimesForSelectedDate();
                comboBoxEnd.Items.Clear();
                //RefreshAvailableStartTimesForSelectedDate();
            }
        }
        private bool IsDuplicateAppointment(int patientId, int doctorId, DateTime date, string timeSlot, string reason)
        {
            if (dataSet1 == null || dataSet1.Pro_Appointment == null)
                return false;

            foreach (DataRow row in dataSet1.Pro_Appointment.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                int dbPatientId = Convert.ToInt32(row["PatientID"]);
                int dbDoctorId = Convert.ToInt32(row["DoctorID"]);
                DateTime dbDate = Convert.ToDateTime(row["AppointmentDate"]);

                // ONLY CORE IDENTITY MATCH
                bool sameCoreAppointment =
                    dbPatientId == patientId &&
                    dbDoctorId == doctorId &&
                    dbDate.Date == date.Date;

                if (sameCoreAppointment)
                {
                    return true; // already exists, block it
                }
            }

            return false;
        }
        private void label17_Click(object sender, EventArgs e)
        {
        //    label17.Text= DateTime.Now.ToString("dd/MM/yyyy").ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            //label18.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString();
        }

        internal void SetTab(int v)
        {
            throw new NotImplementedException();
        }
        private int GetSelectedDoctorId()
        {
            int doctorId;

            if (comboBox1DoctorName.SelectedValue != null &&
                int.TryParse(comboBox1DoctorName.SelectedValue.ToString(), out doctorId))
            {
                return doctorId;
            }

            return 0;
        }
        private int GetActiveDoctorId()
        {
            // Admin mode: must use selected doctor
            if (!(this.MdiParent is MainForm main))
                return GetSelectedDoctorId();

            if (main.CurrentRole == "Doctor")
                return GetLoggedInDoctorId();

            return GetSelectedDoctorId();
        }
        private void ApplyNurseFilter()
        {
            try
            {
                if (newApointmentsBindingSource == null)
                    return;

                if (!(this.MdiParent is MainForm main))
                    return;

                if (main.CurrentRole == "Admin")
                {
                    newApointmentsBindingSource.RemoveFilter();
                    dataGridViewInnerJoin.DataSource = newApointmentsBindingSource;
                    return;
                }

                string nurseName = GetLoggedInNurseName();

                if (string.IsNullOrWhiteSpace(nurseName))
                {
                    newApointmentsBindingSource.RemoveFilter();
                }
                else
                {
                    newApointmentsBindingSource.Filter =
                        $"NurseName = '{nurseName.Replace("'", "''")}'";
                }

                dataGridViewInnerJoin.DataSource = newApointmentsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nurse filter error: " + ex.Message);
            }
        }

        private void dataGridViewInnerJoin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewInnerJoin.CurrentRow == null)
                return;
            dataGridViewInnerJoin.CurrentRow.DefaultCellStyle.BackColor = Color.LightYellow;
            selectedAppointmentId =
                Convert.ToInt32(dataGridViewInnerJoin.CurrentRow.Cells[0].Value);

            MessageBox.Show("Selected Appointment ID: " + selectedAppointmentId);
        }
        private string GetLoggedInNurseName()
        {
            if (this.MdiParent is MainForm main && main.CurrentDataRow != null && main.CurrentRole == "Nurse")
            {
                var dr = main.CurrentDataRow;

                if (dr.Table.Columns.Contains("FullName") && dr["FullName"] != DBNull.Value)
                {
                    return dr["FullName"].ToString();
                }
            }

            return string.Empty;
        }
        private int selectedAppointmentId = -1;
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if(selectedAppointmentId == -1)
    {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            // Enable editing mode
            dataGridViewInnerJoin.ReadOnly = false;

            // Lock everything
            foreach (DataGridViewColumn col in dataGridViewInnerJoin.Columns)
            {
                col.ReadOnly = true;
            }

            // Unlock ONLY Status column
            dataGridViewInnerJoin.Columns["AppointmentStatus"].ReadOnly = false;

            MessageBox.Show("You can now update Appointment Status only.");
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                proAppointmentBindingSource.EndEdit();

                string newStatus =
                    dataGridViewInnerJoin.CurrentRow.Cells["AppointmentStatus"].Value.ToString();

                pro_AppointmentTableAdapter.UpdateAppointmentStatus(
                    newStatus,
                    selectedAppointmentId
                );

                pro_AppointmentTableAdapter.Fill(dataSet1.Pro_Appointment);
                newAppointmentsTableAdapter.Fill(this.dataSet1.NewApointments);

                MessageBox.Show("Status updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            /* this.Validate();
             proAppointmentBindingSource.EndEdit();
             pro_AppointmentTableAdapter.Update(dataSet1.Pro_Appointment);
                 pro_AppointmentTableAdapter.Fill(this.dataSet1.Pro_Appointment);
                 MessageBox.Show("Status Updated Successfully!");
                 BuildBookedSlotsFromDataset();
                 RefreshAvailableStartTimesForSelectedDate();*/
        }

        private void label17_Click_1(object sender, EventArgs e)
        {
       
        }

        private void txtSearchDoctor_TextChanged(object sender, EventArgs e)
        {
           newApointmentsBindingSource.Filter = "DoctorName LIKE '%"+txtSearchDoctor.Text+"%'";
                       //     patientBindingSource.Filter = "FullName LIKE '%" + txtSP.Text + "%'";
        }
    }
}
