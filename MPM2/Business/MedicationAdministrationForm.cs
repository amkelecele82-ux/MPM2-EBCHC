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

            // ✅ DATE FIX
            DateTime date = dateTimePicker1.Value.Date;

            if (filter != "") filter += " AND ";

            filter += $"Admnistered_at >= #{date:MM/dd/yyyy}# AND Admnistered_at < #{date.AddDays(1):MM/dd/yyyy}#";

            customMedAdmBindingSource.Filter = filter;


            if (dgvMedAdministration.CurrentRow == null)
                return;

            String notes = dgvMedAdministration.CurrentRow.Cells["Notes"].Value.ToString();

            if (notes != null)
            {
                RTBNotes.Text = notes;
            }
            else
            {
                RTBNotes.Clear();
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
    }
}
