using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void AppointmentForm1_Load(object sender, EventArgs e)
        {
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
                dr["Patient ID"] = patientDataGridView.CurrentRow.Cells[0].Value.ToString();
                dr["Appointment Status"] = txtAppointmentStatus.Text;
                dr["Start Time"] = comboBox1.SelectedItem.ToString();
                dr["End Time"] = comboBox2.SelectedItem.ToString(); 
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
    }
}
