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
    public partial class PrescriptionForm : Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.dataSet11.Prescription);
            // TODO: This line of code loads data into the 'dataSet11.Prescription' table. You can move, or remove it, as needed.
           // this.prescriptionTableAdapter.Fill(this.dataSet11.Prescription);
            // TODO: This line of code loads data into the 'dataSet1.Prescription' table. You can move, or remove it, as needed.
           // this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);

        }

        private void txtPrscrName_TextChanged(object sender, EventArgs e)
        {
            prescriptionBindingSource2.Filter= "medicationName LIKE '%" + txtPrscrName.Text + "%'";  
        }

        private void lblPatientNamePresc_Click(object sender, EventArgs e)
        {

        }

        private void lblDoctorNamePresc_Click(object sender, EventArgs e)
        {

        }

        private void lblDateIssuedPrescr_Click(object sender, EventArgs e)
        {

        }
    }
}
