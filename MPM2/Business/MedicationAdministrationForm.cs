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
    public partial class MedicationAdministrationForm : Form
    {
        public MedicationAdministrationForm()
        {
            InitializeComponent();
        }

        private void MedicationAdministrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.CustomMedAdm' table. You can move, or remove it, as needed.
            this.customMedAdmTableAdapter.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);
            // TODO: This line of code loads data into the 'dataSet11.Prescriptionn_' table. You can move, or remove it, as needed.
            this.prescriptionn_TableAdapter.Fill(this.dataSet11.Prescriptionn_);
            // TODO: This line of code loads data into the 'dataSet11.MedicationAdministration' table. You can move, or remove it, as needed.
            this.medicationAdministrationTableAdapter.Fill(this.dataSet11.MedicationAdministration);
            
            dgvMedAdministration.Columns["Notes"].Visible = false;
            CBStatus.Items.Add("Pending");
            CBStatus.Items.Add("Completed");
            CBStatus.Items.Add("Missed");
            CBStatus.Items.Add("Delayed");
            CBStatus.SelectedIndex = 0;


        }
        public void SetTab(int tabIndex)
        {
            // Set the selected tab index
            tabControl1.SelectedIndex = tabIndex;
        }

        private void ApplyFilter()
        {
            string filter = "";

            string doctor = TBDoctor.Text.Replace("'", "''");
            string patient = TBPatient.Text.Replace("'", "''");
            string medicine = TBMedicine.Text.Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(doctor))
                filter += $"DoctorName LIKE '%{doctor}%'";

            if (!string.IsNullOrWhiteSpace(patient))
            {
                if (filter != "") filter += " AND ";
                filter += $"PatientName LIKE '%{patient}%'";
            }

            if (!string.IsNullOrWhiteSpace(medicine))
            {
                if (filter != "") filter += " AND ";
                filter += $"MedicineName LIKE '%{medicine}%'";
            }

            // ✅ Status
            if (RBPending.Checked)
            {
                if (filter != "") filter += " AND ";
                filter += "status = 'Pending'";
            }
            else if (RBCompleted.Checked)
            {
                if (filter != "") filter += " AND ";
                filter += "status = 'Completed'";
            }
            else if (RBMissed.Checked)
            {
                if (filter != "") filter += " AND ";
                filter += "status = 'Missed'";
            }
            else if (RBDelayed.Checked)
            {
                if (filter != "") filter += " AND ";
                filter += "status = 'Delayed'";
            }

            DateTime date = dateTimePicker1.Value.Date;

            if (filter != "") filter += " AND ";

            filter += $"Admnistered_at >= #{date:MM/dd/yyyy}# AND Admnistered_at < #{date.AddDays(1):MM/dd/yyyy}#";

            customMedAdmBindingSource.Filter = filter;


            if (dgvMedAdministration.CurrentRow == null)
                return;

          ChangeValues();

        }
        private void ResetFilter()
        {
            customMedAdmBindingSource.RemoveFilter();
            TBDoctor.Clear();
            TBPatient.Clear();
            TBMedicine.Clear();
            RBPending.Checked = false;
            RBCompleted.Checked = false;
            RBMissed.Checked = false;
            RBDelayed.Checked = false;
            dateTimePicker1.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
            RTBNotes.Clear();

        }
        private void ChangeValues()
        {
            if (dgvMedAdministration.CurrentRow == null ||
                dgvMedAdministration.CurrentRow.IsNewRow)
            {
                RTBNotes.Clear();
                TBDosageAmount.Clear();
                CBStatus.SelectedIndex = -1;
                return;
            }

            var row = dgvMedAdministration.CurrentRow;
            var notesValue = row.Cells["Notes"]?.Value;

            RTBNotes.Text = notesValue != null ? notesValue.ToString() : "";
            var dosageValue = row.Cells["frequencyInstanceDataGridViewTextBoxColumn"]?.Value;
            TBDosageAmount.Text = dosageValue != null ? dosageValue.ToString() : "";
            var statusValue = row.Cells["statusDataGridViewTextBoxColumn"]?.Value;

            if (statusValue != null)
            {
                string status = statusValue.ToString();

                CBStatus.SelectedItem = CBStatus.Items
                    .Cast<string>()
                    .FirstOrDefault(item => item.Equals(status, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                CBStatus.SelectedIndex = -1;
            }
        }

        private void TBDoctor_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void TBPatient_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void TBMedicine_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void RBPending_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void RBCompleted_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void RBMissed_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void RBDelayed_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void dgvMedAdministration_SelectionChanged(object sender, EventArgs e)
        {
            ChangeValues();
        }
    }
}
