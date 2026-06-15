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
        int nid;
        public MedicationAdministrationForm()
        {
            InitializeComponent();
        }

        private void MedicationAdministrationForm_Load(object sender, EventArgs e)
        {
            if(this.MdiParent is MainForm mf)
            {
                if (mf != null)
                {
                    if (mf.CurrentRole != "Nurse")
                    {
                        MessageBox.Show("Access Denied. Only Nurses can access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        return;
                    }
                    else
                    {
                        nid = Convert.ToInt32(mf.CurrentDataRow["NurseID"]);
                    }
                }
            }
            // TODO: This line of code loads data into the 'dataSet11.customPrescription' table. You can move, or remove it, as needed.
            this.customPrescriptionTableAdapter.Fill(this.dataSet11.customPrescription);
            // TODO: This line of code loads data into the 'dataSet11.CustomMedAdm' table. You can move, or remove it, as needed.
            if (nid != 0)
            {
                this.customMedAdmTableAdapter.FillByNurseID(this.dataSet11.CustomMedAdm, nid);
            }
            else
            {
                this.customMedAdmTableAdapter.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);
            }
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

            CBStatus2.Items.Add("Pending");
            CBStatus2.Items.Add("Completed");
            CBStatus2.Items.Add("Missed");
            CBStatus2.Items.Add("Delayed");
            CBStatus2.SelectedIndex = 0;

            dgvMedAdministration.Columns["medication_AdministratorID"].Visible = false;
            dgvPrescription.Columns["DoctorID"].Visible = false;
            dgvPrescription.Columns["PatientID"].Visible = false;
            dgvPrescription.Columns["prescriptionIDDataGridViewTextBoxColumn"].Visible = false;
        }
        public void SetTab(int tabIndex)
        {
            // Set the selected tab index
            tabControl1.SelectedIndex = tabIndex;
        }

        //Functionality for first tab
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
            var frequencycount = row.Cells["frequencyInstanceDataGridViewTextBoxColumn"]?.Value;
            TBFrequency2.Text = frequencycount != null ? frequencycount.ToString() : "";
            var statusValue = row.Cells["statusDataGridViewTextBoxColumn"]?.Value;
            var dosageAmount = row.Cells["dosageGivenDataGridViewTextBoxColumn"]?.Value;
            TBDosageAmount.Text = dosageAmount != null ? dosageAmount.ToString() : "";

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

        private void Recordbutton_Click(object sender, EventArgs e)
        {
            if (dgvPrescription.CurrentRow == null ||
                dgvPrescription.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a valid prescription to record medication administration.", "No Prescription Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(TBDosage.Text))
            {
                MessageBox.Show("Please enter a valid dosage amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(TBFrequency.Text) || !int.TryParse(TBFrequency.Text, out _))
            {
                MessageBox.Show("Please enter a valid frequency (number of times medication is administered).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CBStatus2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid status for the medication administration.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(RTBNotes2.Text))
            {
                MessageBox.Show("Please enter notes for the medication administration.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nid=0;
            int prid=0;
            string nursename = "Default";
            string notes = RTBNotes2.Text;
            if (this.MdiParent is MainForm mf)
            {
                if (mf != null)
                {
                    if (mf.CurrentRole != "Nurse")
                    {
                        MessageBox.Show("Access Denied. Only Administrators can access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        return;
                    }
                    
                    nid = Convert.ToInt32(mf.CurrentDataRow["NurseID"]);
                    prid = Convert.ToInt32(dgvPrescription.CurrentRow.Cells["prescriptionIDDataGridViewTextBoxColumn"].Value);
                    nursename = mf.CurrentDataRow["FullName"].ToString();

                }
            }
            DateTime adminAt = DateTime.Now;
            string dosage = TBDosage.Text;
            string status = CBStatus2.SelectedItem?.ToString() ?? "Pending";
            int frequency = Convert.ToInt32(TBFrequency.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to record this medication administration?\nNurse:"+nursename+"\nAdministered at:"+adminAt+"\nDosage:"+dosage+"\nStatus:"+status+"\nFrequency:"+frequency+"\nNotes:"+notes, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.medicationAdministrationTableAdapter.InsertMedAdministration(nid, prid, adminAt, dosage, status, frequency,notes);
                MessageBox.Show("Medication recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the data grid view to show the newly added record
                this.customMedAdmTableAdapter.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);

            }
        }

        private void TBPPatient_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void TBPDoctor_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void TBCMedicine_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }
        private void ApplyFilter2()
        {
            string filter = "";

            string doctor = TBPDoctor.Text.Replace("'", "''");
            string patient = TBPPatient.Text.Replace("'", "''");
            string medicine = TBCMedicine.Text.Replace("'", "''");

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
                filter += $"MedicationName LIKE '%{medicine}%'";
            }

            if (dateTimePicker2.Checked)
            {
                if (filter != "") filter += " AND ";

                DateTime date = dateTimePicker2.Value.Date;

                filter += $"DateIssued >= #{date:MM/dd/yyyy}# AND DateIssued < #{date.AddDays(1):MM/dd/yyyy}#";
            }

            customPrescriptionBindingSource.Filter = filter;

            ChangeValues2();

        }
        private void ChangeValues2()
        {
            if (dgvPrescription.CurrentRow == null ||
                dgvPrescription.CurrentRow.IsNewRow)
            {
                return;
            }

            var row = dgvPrescription.CurrentRow;
            var patient2 = row.Cells["dataGridViewTextBoxColumn1"]?.Value;

            string p2 = patient2 != null ? patient2.ToString() : "";
            lblPatient2.Text = "Patient: " + p2;


            var doctor2 = row.Cells["dataGridViewTextBoxColumn2"]?.Value;
            string d2 = doctor2 != null ? doctor2.ToString() : "";
            lblDoctor2.Text = "Prescription by: " + d2;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {


            if (dgvMedAdministration.CurrentRow == null || dgvMedAdministration.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a valid medication administration record to update.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentStatus = dgvMedAdministration.CurrentRow
                .Cells["statusDataGridViewTextBoxColumn"].Value?.ToString();

            var adminValue = dgvMedAdministration.CurrentRow
                .Cells["dataGridViewTextBoxColumn4"].Value;

            if (currentStatus == "Completed")
            {
                MessageBox.Show("This record is locked and cannot be edited.",
                                "Update Not Allowed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (adminValue != null && adminValue != DBNull.Value)
            {
                DateTime administeredAt = Convert.ToDateTime(adminValue);

                if (administeredAt.Date != DateTime.Today)
                {
                    MessageBox.Show("You can only modify today's medication records.",
                                    "Update Not Allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this medication administration record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(dgvMedAdministration.CurrentRow.Cells["medication_AdministratorID"].Value);
                string newNotes = RTBNotes.Text;
                string newDosage = TBDosageAmount.Text;
                string newStatus = CBStatus.SelectedItem?.ToString() ?? "Pending";
                this.medicationAdministrationTableAdapter.UpdateQuery(newDosage, newStatus, Convert.ToInt32(TBFrequency2.Text), newNotes, selectedId);
                MessageBox.Show("Medication administration record updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.customMedAdmTableAdapter.FillByMedAdmPrescripNurseDoctorPatient(this.dataSet11.CustomMedAdm);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPrescription_SelectionChanged(object sender, EventArgs e)
        {
            ChangeValues2();
        }
    }
}
