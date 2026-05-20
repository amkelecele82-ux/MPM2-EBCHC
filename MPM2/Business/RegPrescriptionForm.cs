using MPM2.Database.DataSet1TableAdapters;
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
    public partial class RegPrescriptionForm : Form
    {
        public RegPrescriptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prescriptionTableAdapter.InsertQuery(
                Convert.ToInt32(textBox1.Text), // PatientID
                textBox2.Text, // MedicationName
                textBox3.Text, // Dosage
                textBox4.Text, // Frequency
                textBox5.Text, // Duration
                textBox6.Text, // Instruction
                DateTime.Now.ToString("yyyy-MM-dd") // DateIssued
            );
        }

        private void RegPrescriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);

        }
    }
}
