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
    public partial class TreatmentForm : Form
    {
        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.dataSet1.Nurse);
            // TODO: This line of code loads data into the 'dataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dataSet1.Doctor);
            // TODO: This line of code loads data into the 'dataSet1.AppointmentView' table. You can move, or remove it, as needed.
            //this.customTreatmentTableAdapter1.Fill(this.dataSet1.customTreatment);
            this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
            dateTimePicker2.Value = DateTime.Today;

            ApplyFilter();

            if (this.MdiParent is MainForm mf)
            {
                if (mf.CurrentRole == "Doctor")
                {
                    int doctorID = Convert.ToInt32(mf.CurrentDataRow["DoctorID"]);
                    string doctorName = mf.CurrentDataRow["FullName"].ToString();
                    this.appointmentViewTableAdapter.FillByDoctorID(this.dataSet1.AppointmentView, doctorID);
                    //this.customTreatmentInfoTableAdapter.FillByDoctor(this.dataSet1.customTreatmentInfo, doctorID, doctorName);
                }
                else if (mf.CurrentRole == "Nurse")
                {
                    int nurseID = Convert.ToInt32(mf.CurrentDataRow["NurseID"]);
                    this.appointmentViewTableAdapter.FillByNurse(this.dataSet1.AppointmentView, nurseID);
                    //this.customTreatmentInfoTableAdapter.FillByNurse(this.dataSet1.customTreatmentInfo, nurseID);
                }
                else
                {
                    this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
                    //this.appointmentViewTableAdapter.Fill(this.dataSet1.AppointmentView);
                }
            }
            else
            {
                this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
            }
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);

            lblCDoctor.Text = "Doctor: " + dgvCDoctor.CurrentRow.Cells["fullNameDataGridViewTextBoxColumn1"].Value.ToString();
            lblCNurse.Text = "Nurse: " + dgvCNurse.CurrentRow.Cells["FullName"].Value.ToString();
            dgvCDoctor.Columns["doctorIDDataGridViewTextBoxColumn1"].Visible = false;
            dgvCNurse.Columns["nurseID"].Visible = false;
            dgvRAppointment.Columns["appointmentIDDataGridViewTextBoxColumn"].Visible = false;
            dgvRAppointment.Columns["appointmentDateDataGridViewTextBoxColumn"].Visible = false;


            dgvTTreatment.Columns["requiresDoctorDataGridViewTextBoxColumn"].Visible = false;
            dgvTTreatment.Columns["requiresNurseDataGridViewTextBoxColumn"].Visible = false;
            dgvTTreatment.Columns["isActiveDataGridViewTextBoxColumn"].Visible = false;
            dgvTTreatment.Columns["descriptionDataGridViewTextBoxColumn"].Visible = false;
            dgvTTreatment.Columns["instructionsDataGridViewTextBoxColumn"].Visible = false;
            dgvTTreatment.Columns["treatmentID"].Visible = false;

            var categories = dataSet1.Treatment.AsEnumerable()
                .Select(r => r["Category"].ToString())
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct();

            CBCCategory.Items.Clear();

            foreach (var cat in categories)
            {
                CBCCategory.Items.Add(cat);
            }


            var treatmentNames = dataSet1.Treatment.AsEnumerable()
                .Select(r => r["FullName"].ToString())
                .Where(name => !string.IsNullOrWhiteSpace(name))
                .Distinct();

            CBRTreatment.Items.Clear();

            foreach (var name in treatmentNames)
            {
                CBRTreatment.Items.Add(name);
            }



            dgvCustomTreatInfo.Columns["notesDataGridViewTextBoxColumn"].Visible = false;
            dgvCustomTreatInfo.Columns["diagnosisDataGridViewTextBoxColumn"].Visible = false;
            dgvCustomTreatInfo.Columns["resultsDataGridViewTextBoxColumn"].Visible = false;
            dgvCustomTreatInfo.Columns["treatmentInformationIDDataGridViewTextBoxColumn"].Visible = false;

        }
        public void SetTab(int tabIndex)
        {
            // Set the selected tab index
            tabControl1.SelectedIndex = tabIndex;
        }

        private void tpCreate_Click(object sender, EventArgs e)
        {

        }

        private void TBCDoctor_TextChanged(object sender, EventArgs e)
        {
            this.doctorTableAdapter.FillByDoctorName(this.dataSet1.Doctor,TBCDoctor.Text.ToString());
        }

        private void TBCNurse_TextChanged(object sender, EventArgs e)
        {
            this.nurseTableAdapter.FillByNurseName(this.dataSet1.Nurse, TBCNurse.Text.ToString());
        }

        private void dgvCDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCDoctor.CurrentRow != null)
            {
                lblCDoctor.Text = "Doctor: " + dgvCDoctor.CurrentRow.Cells["fullNameDataGridViewTextBoxColumn1"].Value.ToString();
            }
        }

        private void dgvCNurse_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCNurse.CurrentRow != null)
                lblCNurse.Text = "Nurse: " + dgvCNurse.CurrentRow.Cells["FullName"].Value.ToString();
 
        }

        private void CNewTreatButton_Click(object sender, EventArgs e)
        {


            int doctorID = Convert.ToInt32(dgvCDoctor.CurrentRow.Cells["doctorIDDataGridViewTextBoxColumn1"].Value);
            int nurseID = Convert.ToInt32(dgvCNurse.CurrentRow.Cells["nurseID"].Value);
            string treatname = TBCTreatName.Text.ToString();
            string description = RTBCDescription.Text.ToString();
            string category = CBCCategory.Text;
            string instructions = RTBCInstruction.Text.ToString();
            byte rd = 0;
            byte rn = 0;
            byte active = 0;
            if (CBCDoctor.Checked)
            {
                rd = 1;
            }
            if (CBCNurse.Checked)
            {
                rn = 1;
            }
            if (CBCActive.Checked)
            {
                active = 1;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to create this treatment? +\nDoctor: "+lblCDoctor.Text.ToString()+"\nNurse: "+lblCNurse.Text.ToString()+"\nTreatment Name: "+treatname+"\nDescription: "+description+"\nCategory: "+category+"\nInstructions: "+instructions, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.treatmentTableAdapter.InsertTreatment(doctorID, nurseID, treatname, description, category, instructions, rd, rn, active);
                MessageBox.Show("Treatment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (this.MdiParent is MainForm mf)
                {
                    if (mf.CurrentRole == "Doctor")
                    {
                        int did = Convert.ToInt32(mf.CurrentDataRow["DoctorID"]);
                        string name = mf.CurrentDataRow["FullName"].ToString();
                        this.appointmentViewTableAdapter.FillByDoctorID(this.dataSet1.AppointmentView, did);
                        this.customTreatmentInfoTableAdapter.FillByDoctor(this.dataSet1.customTreatmentInfo, did,name);
                    }
                    else if (mf.CurrentRole == "Nurse")
                    {
                        int nid = Convert.ToInt32(mf.CurrentDataRow["NurseID"]);
                        string name = mf.CurrentDataRow["FullName"].ToString();
                        this.appointmentViewTableAdapter.FillByNurse(this.dataSet1.AppointmentView, nid);
                        this.customTreatmentInfoTableAdapter.FillByNurse(this.dataSet1.customTreatmentInfo, nid);
                    }
                    else
                    {
                        this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
                        this.appointmentViewTableAdapter.Fill(this.dataSet1.AppointmentView);
                    }
                }
                else
                {
                    this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
                }
                // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
                this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);

            }
        }
        private void ApplyFilter()
        {
            string filter = "";

            string treatmentname = TBVTreatName.Text.Replace("'", "''");
            string performedBy = TBVPatientName.Text.Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(treatmentname))
                filter += $"TreatmentName LIKE '%{treatmentname}%'";

            //if (!string.IsNullOrWhiteSpace(performedBy))
            //{
            //    if (filter != "") filter += " AND ";
            //    filter += $"performedBy LIKE '%{performedBy}%'";
            //}

            DateTime date = dateTimePicker2.Value.Date;

            if (filter != "") filter += " AND ";

            filter += $"perfomed_at >= #{date:yyyy-MM-dd}# AND perfomed_at < #{date.AddDays(1):yyyy-MM-dd}#";

            customTreatmentInfoBindingSource.Filter = filter;


            if (dgvCustomTreatInfo.CurrentRow == null)
                return;

            ChangeValues();
        }
        private void ChangeValues()
        {
            if (dgvCustomTreatInfo.CurrentRow == null ||dgvCustomTreatInfo.CurrentRow.IsNewRow)
            {
                RTBVNotes.Clear();
                RTBVDiagnosis.Clear();
                RTBVResults.Clear();
                return;
            }
            var row = dgvCustomTreatInfo.CurrentRow;
            var notesValue = row.Cells["notesDataGridViewTextBoxColumn"]?.Value;
            RTBVNotes.Text = notesValue != null ? notesValue.ToString() : "";

            var diagnosisValue = row.Cells["diagnosisDataGridViewTextBoxColumn"]?.Value;
            RTBVDiagnosis.Text = diagnosisValue != null ? diagnosisValue.ToString() : "";   

            var resultsValue = row.Cells["resultsDataGridViewTextBoxColumn"]?.Value;
            RTBVResults.Text = resultsValue != null ? resultsValue.ToString() : "";
        }

        private void TBVTreatName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void TBVPatientName_TextChanged(object sender, EventArgs e)
        {
            this.customTreatmentInfoTableAdapter.FillByPerformed(this.dataSet1.customTreatmentInfo, TBVPatientName.Text.ToString());
            //ApplyFilter();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           ApplyFilter();
        }

        private void dgvCustomTreatInfo_SelectionChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter2()
        {
            string filter = "";

            string patientname = TBRPatient.Text.Replace("'", "''");
            string doctorname = TBRDoctor.Text.Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(patientname))
                filter += $"PatientName LIKE '%{patientname}%'";

            if (!string.IsNullOrWhiteSpace(doctorname))
            {
                if (filter != "") filter += " AND ";
                filter += $"DoctorName LIKE '%{doctorname}%'";
            }

            DateTime date = dateTimePicker1.Value.Date;

            if (filter != "") filter += " AND ";

            filter += $"AppointmentDate >= #{date:MM/dd/yyyy}# AND AppointmentDate < #{date.AddDays(1):MM/dd/yyyy}#";

            appointmentViewBindingSource.Filter = filter;


            if (dgvRAppointment.CurrentRow == null)
                return;

            ChangeValues2();
        }
        private void ChangeValues2()
        {
            if (dgvRAppointment.CurrentRow == null || dgvRAppointment.CurrentRow.IsNewRow)
            {
                lblRDoctor.Text = "Doctor: None";
                lblRPatient.Text = "Patient: None";
                lblRAppointmentDate.Text = "Appointment Date: None";
                return;
            }
            var row = dgvRAppointment.CurrentRow;
            var doctorValue = row.Cells["doctorNameDataGridViewTextBoxColumn"]?.Value;
            lblRDoctor.Text = doctorValue != null ? $"Doctor: {doctorValue}" : "Doctor: None";
            var patientValue = row.Cells["patientNameDataGridViewTextBoxColumn"]?.Value;
            lblRPatient.Text = patientValue != null ? $"Patient: {patientValue}" : "Patient: None";
            var appointmentDateValue = row.Cells["appointmentDateDataGridViewTextBoxColumn"]?.Value;

            lblRAppointmentDate.Text = appointmentDateValue != null
                ? "Appointment Date: " + Convert.ToDateTime(appointmentDateValue).ToString("dd MMMM yyyy")
                : "Appointment Date: None";
            //var appointmentDateValue = row.Cells["appointmentDateDataGridViewTextBoxColumn"]?.Value;
            //lblRAppointmentDate.Text = appointmentDateValue != null ? $"Appointment Date: {appointmentDateValue}" : "Appointment Date: None";
        }
        private void TBRPatient_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void TBRDoctor_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void dgvRAppointment_SelectionChanged(object sender, EventArgs e)
        {
            ApplyFilter2();
        }

        private void RRecordButton_Click(object sender, EventArgs e)
        {
            if (dgvRAppointment.CurrentRow == null || dgvRAppointment.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an appointment to record the treatment.", "No Appointment Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CBRTreatment.SelectedItem == null)
            {
                MessageBox.Show("Please select a treatment.", "No Treatment Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int aid = Convert.ToInt32(dgvRAppointment.CurrentRow.Cells["appointmentIDDataGridViewTextBoxColumn"].Value);

            string selectedName = CBRTreatment.Text;

            var row = dataSet1.Treatment.AsEnumerable()
                .FirstOrDefault(r => r["FullName"].ToString() == selectedName);
            int tid = Convert.ToInt32(row["treatmentID"]);
            DateTime performedAt = DateTime.Now;
            string notes = RTBRNotes.Text.ToString();
            string diagnosis = RTBRDiagnosis.Text.ToString();
            string results = RTBRResult.Text.ToString();
            string performedBy = "";
            string role = "";
            int medid = 0;
            if (this.MdiParent is MainForm mf)
            {
                performedBy = mf.CurrentDataRow["FullName"].ToString();
                role = mf.CurrentRole;
                if (role == "Doctor")
                {
                    medid = Convert.ToInt32(mf.CurrentDataRow["DoctorID"]);
                }
                else if (role == "Nurse")
                {
                    medid = Convert.ToInt32(mf.CurrentDataRow["NurseID"]);
                }
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to record this treatment?\nTreatment: {selectedName}\nPatient: {lblRPatient.Text.Replace("Patient: ", "")}\nDoctor: {lblRDoctor.Text.Replace("Doctor: ", "")}\nPerformed At: {performedAt}\nNotes: {notes}\nDiagnosis: {diagnosis}\nResults: {results}\nPerformed By: {performedBy}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.treatmentInformationTableAdapter1.InsertNewTreatmentInformation(aid, tid, performedAt, notes, diagnosis, results, performedBy);
                MessageBox.Show("Treatment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (role == "Doctor")
                    {
                        int did = medid;
                        string doctorName = performedBy;
                        this.appointmentViewTableAdapter.FillByDoctorID(this.dataSet1.AppointmentView, did);
                        this.customTreatmentInfoTableAdapter.FillByDoctor(this.dataSet1.customTreatmentInfo, did, doctorName);
                        ApplyFilter();
                    }
                    else if (role == "Nurse")
                    {
                        int nid = medid;
                        this.appointmentViewTableAdapter.FillByNurse(this.dataSet1.AppointmentView, nid);
                        this.customTreatmentInfoTableAdapter.FillByNurse(this.dataSet1.customTreatmentInfo, nid);
                        ApplyFilter();
                    }
                    else
                    {
                        this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
                        this.appointmentViewTableAdapter.Fill(this.dataSet1.AppointmentView);
                    ApplyFilter();
                }
                }
                else
                {
                    this.customTreatmentInfoTableAdapter.Fill(this.dataSet1.customTreatmentInfo);
                ApplyFilter();
            }
                // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
                this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
        }

        private void dgvRAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TBTTreatmentName_TextChanged(object sender, EventArgs e)
        {
            this.customTreatmentTableAdapter1.FillByTreatmentName(this.dataSet1.customTreatment, TBTTreatmentName.Text.ToString());
            ChangeValues3();
        }
        private void ChangeValues3()
        {
            if (dgvTTreatment.CurrentRow == null || dgvTTreatment.CurrentRow.IsNewRow)
            {
                lblTActive.Text = "Active: -";
                lblTRDoctor.Text = "Doctor: None";
                lblTRNurse.Text = "Nurse: None";
                RTBTDescription.Clear();
                RTBTInstruction.Clear();
                return;
            }
            int requiresdoctor = 0;
            requiresdoctor = Convert.ToInt32(dgvTTreatment.CurrentRow.Cells["requiresDoctorDataGridViewTextBoxColumn"].Value);
            if (requiresdoctor == 0)
            {
                lblTRDoctor.Text = "Doctor: No";
            }
            else
            {
                lblTRDoctor.Text = "Doctor: Yes";
            }
            int requiresnurse = 0;
            requiresnurse = Convert.ToInt32(dgvTTreatment.CurrentRow.Cells["requiresNurseDataGridViewTextBoxColumn"].Value);
            if (requiresnurse == 0)
            {
                lblTRNurse.Text = "Nurse: No";
            }
            else
            {
                lblTRNurse.Text = "Nurse: Yes";
            }
            int active = 0;
            active = Convert.ToInt32(dgvTTreatment.CurrentRow.Cells["isActiveDataGridViewTextBoxColumn"].Value);
            if (active == 0)
            {
                //lblTActive.Text = "Active: No";
                RTBTActive.Checked = false;
                RTBTInactive.Checked = true;
            }
            else
            {
                //lblTActive.Text = "Active: Yes";
                RTBTInactive.Checked = false;
                RTBTActive.Checked = true;
            }

            var row = dgvTTreatment.CurrentRow;
            var description = row.Cells["descriptionDataGridViewTextBoxColumn"]?.Value;
            RTBTDescription.Text = description != null ? $"{description}" : "";
            var instruction = row.Cells["instructionsDataGridViewTextBoxColumn"]?.Value;
            RTBTInstruction.Text = instruction != null ? $"{instruction}" : "";
        }

        private void dgvTTreatment_SelectionChanged(object sender, EventArgs e)
        {
            ChangeValues3();
        }

        private void ActiveChangeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change the active status of this treatment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int treatmentID = Convert.ToInt32(dgvTTreatment.CurrentRow.Cells["treatmentID"].Value);
                if (RTBTActive.Checked)
                {
                    this.treatmentTableAdapter.UpdateState(1, treatmentID);
                    MessageBox.Show("Treatment activated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(RTBTInactive.Checked)
                {
                    this.treatmentTableAdapter.UpdateState(0, treatmentID);
                    MessageBox.Show("Treatment deactivated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.customTreatmentTableAdapter1.Fill(this.dataSet1.customTreatment);
            }
        }
    }
}
