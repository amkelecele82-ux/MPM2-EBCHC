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
    public partial class PatientForm1 : Form
    {
        public PatientForm1()
        {
            InitializeComponent();
        }

        private void PatientForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataSet1.Patient);



        }

        private void TBPName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TBPName_TextChanged_1(object sender, EventArgs e)
        {
            patientTableAdapter.FillByPatientName(dataSet1.Patient, TBPName.Text);
        }

          
    }
}
