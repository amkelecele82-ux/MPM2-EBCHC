using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2.Business
{
    public partial class AppointmentForm1 : Form
    {
        public AppointmentForm1()
        {
            InitializeComponent();

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
        private void AppointmentForm1_Load(object sender, EventArgs e)
        {
            int doctorId = GetLoggedInDoctorId();
            if (doctorId != 0)
            {
                txtDoctorIDBook.Text = doctorId.ToString();
                txtDoctorIDBook.ReadOnly = true;
                //button1.Enabled = true;
            }
            else
            {
                // If not logged-in as a doctor, disable create and leave textbox empty / read-only.
                txtDoctorIDBook.Text = string.Empty;
                txtDoctorIDBook.ReadOnly = true;
                //button1.Enabled = false;
            }
            // TODO: This line of code loads data into the 'dataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.dataSet1.Appointment);
            // TODO: This line of code loads data into the 'dataSet1.LiteAppointment' table. You can move, or remove it, as needed.
            // this.LiteAppointmentsTableAdapter.Fill(this.dataSet1.LiteAppointments);
            // TODO: This line of code loads data into the 'dataSet11.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataSet11.Patient);
            // TODO: This line of code loads data into the 'dataSet1.AppointmentView' table. You can move, or remove it, as needed.
            this.appointmentViewTableAdapter.Fill(this.dataSet1.AppointmentView);
            comboBox1.Items.Clear();

            DateTime start = DateTime.ParseExact("09:00", "HH:mm", null);

            DateTime end = DateTime.ParseExact("16:30", "HH:mm", null);

            while (start <= end)
            {
                comboBox1.Items.Add(start.ToString("hh:mm tt")); // AM/PM format
                start = start.AddMinutes(30);
            }

            // Optional: select the first item automatically
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            txtAppointmentStatus.Text = "Scheduled";
        }
        public void SetTab(int index)
        {
            TCAppointments.SelectedIndex = index;
        }

        private void TPBA_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedStart = DateTime.ParseExact(comboBox1.SelectedItem.ToString(), "hh:mm tt", null);

            // Clear ComboBox2
            comboBox2.Items.Clear();

            // End time limit
            DateTime end = DateTime.ParseExact("16:30", "HH:mm", null);

            // Populate ComboBox2 with times after the selected start
            DateTime next = selectedStart.AddMinutes(30);
            while (next <= end)
            {
                comboBox2.Items.Add(next.ToString("hh:mm tt"));
                next = next.AddMinutes(30);
            }

            // Optional: auto-select the first available end time
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                var dr=dataSet1.Appointment.NewAppointmentRow();
           
                dr["Patient Name"] = patientDataGridView.CurrentRow.Cells[1].Value.ToString();
                dr["Patient_ID"] = patientDataGridView.CurrentRow.Cells[0].Value.ToString();
                dr["Doctor_ID"] = txtDoctorIDBook.Text;
                dr["Nurse ID"] =txtNurseID.Text;    
                dr["Appointment Status"] = txtAppointmentStatus.Text;
                dr["StartTime"] = comboBox1.SelectedItem.ToString();
                dr["EndTime"] = comboBox2.SelectedItem.ToString(); 
                dr["Appointment_Date"] = dateTimePicker1.Value.Date;

                dataSet1.Appointment.AddAppointmentRow(dr);
                MessageBox.Show("Appointment details loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                appointmentTableAdapter.Fill(this.dataSet1.Appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patientBindingSource.Filter = "FullName LIKE '%" + txtSearchPatientName.Text + "%'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPatientName.Text = patientDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required selections
                if (patientDataGridView.CurrentRow == null || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a patient and both start and end times.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int patientId = int.Parse(patientDataGridView.CurrentRow.Cells[0].Value.ToString());
                int doctorId = int.Parse(txtDoctorIDBook.Text);
                int nurseId = int.Parse(txtNurseID.Text);
                string status = txtAppointmentStatus.Text;
                  string appointmentDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");


                // Convert date/time to DB-friendly formats
                // Date in ISO format (adjust if your DB expects something else)
             //   string appointmentDate = dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                // comboBox items are like "09:00 AM" — parse them and format as 24-hour time expected by SQL/TimeSpan
                DateTime startDt = DateTime.ParseExact(comboBox1.SelectedItem.ToString().Trim(), "hh:mm tt", CultureInfo.InvariantCulture);
                DateTime endDt = DateTime.ParseExact(comboBox2.SelectedItem.ToString().Trim(), "hh:mm tt", CultureInfo.InvariantCulture);

                // Most SQL TIME columns accept "HH:mm:ss" — use that
                string startTime = startDt.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                string endTime = endDt.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

                appointmentTableAdapter.InsertQuery(
                    patientId,
                    doctorId,
                    nurseId,
                    status,
                    appointmentDate,
                    startTime,
                    endTime
                );
                MessageBox.Show("Appointment details loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                appointmentTableAdapter.Fill(this.dataSet1.Appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoctorIDBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void liteAppointmentdataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var dr = dataSet1.appProgress.NewappProgressRow();
                dr["AppointmentID"] = AppointmentdataGridView3.CurrentRow.Cells[0].Value.ToString();
               // dr["Patient Name"] = patientDataGridView.CurrentRow.Cells[1].Value.ToString();
                dr["Patient_ID"] = patientDataGridView.CurrentRow.Cells[0].Value.ToString();
              //  dr["Doctor_ID"] = txtDoctorIDBook.Text;
               // dr["Nurse ID"] = txtNurseID.Text;
                dr["Appointment_Status"] = txtAppointmentStatus.Text;
                dr["StartTime"] = comboBox1.SelectedItem.ToString();
                dr["EndTime"] = comboBox2.SelectedItem.ToString();
                dr["Appointment_Date"] = dateTimePicker1.Value.Date;

                dataSet1.appProgress.AddappProgressRow(dr);
                MessageBox.Show("Appointment details loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //appointmentTableAdapter.Fill(this.dataSet1.Appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointProgressTabPage_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = appProgressDataGridView.CurrentRow;
            if (row != null)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = true;
                }
                row.Cells[5].ReadOnly = false;

                appProgressDataGridView.CurrentCell = row.Cells[5];
                appProgressDataGridView.BeginEdit(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = appProgressDataGridView.CurrentRow;

            if (row != null)
            {
                int appointmentId = Convert.ToInt32(row.Cells[0].Value);
                string newStatus = row.Cells[5].Value.ToString();
                appointmentTableAdapter.UpdateStatus(newStatus, appointmentId);
                this.appointmentTableAdapter.Fill(this.dataSet1.Appointment);
                DataGridViewRow liteRow = AppointmentdataGridView3.CurrentRow;
                if (liteRow != null && Convert.ToInt32(liteRow.Cells[0].Value) == appointmentId)
                {
                    liteRow.Cells[4].Value = newStatus;
                }

                MessageBox.Show("Status updated successfully!",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void liteAppointmentdataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
