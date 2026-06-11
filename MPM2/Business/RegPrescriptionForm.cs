using MPM2.Database.DataSet1TableAdapters;
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
    public partial class RegPrescriptionForm : Form
    {
        public RegPrescriptionForm()
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
        private void button1_Click(object sender, EventArgs e)
        {
            int doctorId = GetLoggedInDoctorId();
            if (doctorId == 0)
            {
                MessageBox.Show("No logged-in doctor found. You must be logged in as a Doctor to create prescriptions.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime now = DateTime.Now;
            maskedTextBox1.Text = now.ToString("dd/MM/yyyy");
            maskedTextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
 
            DateTime dateIssued;
            string[] acceptedFormats = { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd" }; // accept common formats
            if (!DateTime.TryParseExact(maskedTextBox1.Text, acceptedFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateIssued))
            {
               
                dateIssued = now;
            }

            // Set the date first
            //maskedTextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // Then call the insert method
            prescriptionn_TableAdapter.InsertPrescription(
                Convert.ToInt32(txtDoctorID.Text), // MedicationName ID
                Convert.ToInt32(textBox3.Text), // Dosage ID
                txtMedicationName.Text,         // Medication Name
                txtDosage.Text,                 // Dosage
                txtFrequency.Text,              // Frequency
                txtDuration.Text,
                 txtInstruction.Text,
                dateIssued
             
            );
            MessageBox.Show("Prescription created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prescriptionn_TableAdapter.Fill(this.dataSet1.Prescriptionn_);



        }

        private void RegPrescriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Prescriptionn_' table. You can move, or remove it, as needed.
            this.prescriptionn_TableAdapter.Fill(this.dataSet1.Prescriptionn_);
            // TODO: This line of code loads data into the 'dataSet1.Prescription' table. You can move, or remove it, as needed.
            // this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);
            int doctorId = GetLoggedInDoctorId();
            if (doctorId != 0)
            {
                txtDoctorID.Text = doctorId.ToString();
                txtDoctorID.ReadOnly = true;
                button1.Enabled = true;
            }
            else
            {
                // If not logged-in as a doctor, disable create and leave textbox empty / read-only.
                txtDoctorID.Text = string.Empty;
                txtDoctorID.ReadOnly = true;
                button1.Enabled = false;
            }
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void txtMedicationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                txtMedicationName.Text = " ";        // Medication Name
                txtDosage.Text = " ";                 // Dosage
                txtFrequency.Text = " ";          // Frequency
                txtDuration.Text = "";
                txtInstruction.Text = "";

                prescriptionn_TableAdapter.UpdatePrescription(
               txtMedicationName.Text,         // Medication Name
               txtDosage.Text,                 // Dosage
               txtFrequency.Text,              // Frequency
               txtDuration.Text,
               txtInstruction.Text);
                prescriptionn_TableAdapter.Fill(this.dataSet1.Prescriptionn_);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating prescription: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            bindingSource1.EndEdit();
            prescriptionn_TableAdapter.Update(this.dataSet1.Prescriptionn_);    
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

