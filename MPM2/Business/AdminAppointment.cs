using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

            this.newAppointmentsTableAdapter.Fill(this.dataSet1.NewApointments);
            this.nurseTableAdapter.Fill(this.dataSet1.Nurse);
            this.patientTableAdapter.Fill(this.dataSet1.Patient);

            // Build in-memory booked slots per doctor from dataset so per-doctor availability is correct
            BuildBookedSlotsFromDataset();

            // Refresh combo boxes for the currently selected date and logged-in doctor
            RefreshAvailableStartTimesForSelectedDate();
            ApplyDoctorFilter();    
            // Ensure dataGridView3 shows filtered view for the logged-in role
            //  ApplyRoleFilter();

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
                }


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
            int currentDoctorId = GetLoggedInDoctorId();
            if (currentDoctorId != 0)
            {
                if (bookedSlotsByDoctor.TryGetValue(currentDoctorId, out var dict)
                    && dict.TryGetValue(selectedDate, out var list))
                    unavailable.AddRange(list);
            }
            else
            {
                foreach (var perDoc in bookedSlotsByDoctor.Values)
                {
                    if (perDoc.TryGetValue(selectedDate, out var list))
                        unavailable.AddRange(list);
                }
            }

            DateTime limit = DateTime.ParseExact("16:30", "HH:mm", CultureInfo.InvariantCulture);
            DateTime next = DateTime.Today.Add(selectedStartTs).AddMinutes(30); // use TimeSpan component
            var blockedStart = DateTime.ParseExact("12:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            var blockedEnd = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

            while (next.TimeOfDay <= limit.TimeOfDay)
            {
                var formatted = next.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                var ts = next.TimeOfDay;

                // skip end times that fall inside blocked window
                if (ts > blockedStart && ts <= blockedEnd)
                {
                    next = next.AddMinutes(30);
                    continue;
                }

                // ensure the interval selectedStartTs -> ts does not overlap any unavailable booking
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

            if (dataSet1 == null || dataSet1.Pro_Appointment == null)
                return;

            foreach (DataRow row in dataSet1.Pro_Appointment.Rows)
            {
                if (row == null)
                    continue;

                // determine doctor id column name and value
                int doctorId = 0;
                if (row.Table.Columns.Contains("DoctorID") && row["DoctorID"] != DBNull.Value)
                    int.TryParse(row["DoctorID"].ToString(), out doctorId);
                else if (row.Table.Columns.Contains("Doctor_ID") && row["Doctor_ID"] != DBNull.Value)
                    int.TryParse(row["Doctor_ID"].ToString(), out doctorId);
                else
                    continue; // skip rows without doctor reference

                if (!row.Table.Columns.Contains("AppointmentDate") || row["AppointmentDate"] == DBNull.Value)
                    continue;

                DateTime apptDate;
                try
                {
                    apptDate = Convert.ToDateTime(row["AppointmentDate"]);
                }
                catch
                {
                    continue;
                }

                if (!row.Table.Columns.Contains("TimeSlots") || row["TimeSlots"] == DBNull.Value)
                    continue;

                string timeSlots = row["TimeSlots"].ToString();
                if (string.IsNullOrWhiteSpace(timeSlots))
                    continue;

                // Expecting "hh:mm tt - hh:mm tt"
                string[] parts = timeSlots.Split(new[] { '-' }, 2);
                if (parts.Length != 2)
                    continue;

                string s = parts[0].Trim();
                string e = parts[1].Trim();

                DateTime sd, ed;
                if (!DateTime.TryParseExact(s, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out sd))
                    continue;
                if (!DateTime.TryParseExact(e, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out ed))
                    continue;

                var dictForDoctor = bookedSlotsByDoctor.ContainsKey(doctorId)
                    ? bookedSlotsByDoctor[doctorId]
                    : (bookedSlotsByDoctor[doctorId] = new Dictionary<DateTime, List<Tuple<TimeSpan, TimeSpan>>>());

                var dateKey = apptDate.Date;
                if (!dictForDoctor.ContainsKey(dateKey))
                    dictForDoctor[dateKey] = new List<Tuple<TimeSpan, TimeSpan>>();

                dictForDoctor[dateKey].Add(Tuple.Create(sd.TimeOfDay, ed.TimeOfDay));
            }
        }
        private void RefreshAvailableStartTimesForSelectedDate()
        {
            comboBoxSta.Items.Clear();
            comboBoxEnd.Items.Clear();

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            var unavailable = new List<Tuple<TimeSpan, TimeSpan>>();

            int currentDoctorId = GetLoggedInDoctorId();

            if (currentDoctorId != 0)
            {
                if (bookedSlotsByDoctor.TryGetValue(currentDoctorId, out var dict) &&
                    dict.TryGetValue(selectedDate, out var list))
                {
                    unavailable.AddRange(list);
                }
            }
            else
            {
                // Optional: show all booked slots across all doctors
                foreach (var perDoc in bookedSlotsByDoctor.Values)
                {
                    if (perDoc.TryGetValue(selectedDate, out var list))
                    {
                        unavailable.AddRange(list);
                    }
                }
            }

            // Lunch break block: 12:00 PM - 1:00 PM
            TimeSpan blockedStart =
                DateTime.ParseExact(
                    "12:00 PM",
                    "hh:mm tt",
                    CultureInfo.InvariantCulture)
                .TimeOfDay;

            TimeSpan blockedEnd =
                DateTime.ParseExact(
                    "01:00 PM",
                    "hh:mm tt",
                    CultureInfo.InvariantCulture)
                .TimeOfDay;

            foreach (string slot in masterTimeSlots)
            {
                DateTime slotDt =
                    DateTime.ParseExact(
                        slot,
                        "hh:mm tt",
                        CultureInfo.InvariantCulture);

                TimeSpan slotTs = slotDt.TimeOfDay;

                // Skip lunch period
                if (slotTs >= blockedStart &&
                    slotTs < blockedEnd)
                {
                    continue;
                }

                // Remove slots that fall inside an existing booking
                bool isUnavailable =
                    unavailable.Any(b =>
                        slotTs >= b.Item1 &&
                        slotTs < b.Item2);

                if (!isUnavailable)
                {
                    comboBoxSta.Items.Add(slot);
                }
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
        private void ApplyRoleFilter()
        {
            try
            {
                if (dataSet1 == null || dataSet1.Pro_Appointment == null)
                    return;

                // Ensure BindingSource exists (create if not in designer)
                if (proAppointmentBindingSource == null)
                {
                    proAppointmentBindingSource = new BindingSource();
                }

                // ALWAYS bind once to table (not DefaultView repeatedly)
                if (proAppointmentBindingSource.DataSource == null)
                {
                    proAppointmentBindingSource.DataSource = dataSet1;
                    proAppointmentBindingSource.DataMember = "Pro_Appointment";
                }

                if (!(this.MdiParent is MainForm main) || main.CurrentDataRow == null)
                {
                    proAppointmentBindingSource.RemoveFilter();
                }
                else if (main.CurrentRole == "Doctor")
                {
                    int doctorId = GetLoggedInDoctorId();

                    if (doctorId != 0)
                    {
                        string docCol =
                            dataSet1.Pro_Appointment.Columns.Contains("DoctorID") ? "DoctorID" :
                            dataSet1.Pro_Appointment.Columns.Contains("Doctor_ID") ? "Doctor_ID" :
                            null;

                        if (!string.IsNullOrEmpty(docCol))
                        {
                            proAppointmentBindingSource.Filter = $"[{docCol}] = {doctorId}";
                        }
                        else
                        {
                            proAppointmentBindingSource.RemoveFilter();
                        }
                    }
                }
                else
                {
                    proAppointmentBindingSource.RemoveFilter();
                }

                // IMPORTANT: bind grid ONLY here
                dataGridViewInnerJoin.DataSource = proAppointmentBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
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
                string dbTimeSlot = row["TimeSlots"].ToString().Trim();
                string dbReason = row["AppointmentReason"].ToString().Trim();

                bool same =
                    dbPatientId == patientId &&
                    dbDoctorId == doctorId &&
                    dbDate.Date == date.Date &&
                    dbTimeSlot.Equals(timeSlot.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    dbReason.Equals(reason.Trim(), StringComparison.OrdinalIgnoreCase);

                if (same)
                    return true;
            }

            return false;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //label17.Text= DateTime.Now.ToString("dd/MM/yyyy").ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {
           // label18.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString();
        }

        internal void SetTab(int v)
        {
            throw new NotImplementedException();
        }
    }
}
