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
            // TODO: This line of code loads data into the 'dataSet11.Prescriptionn_' table. You can move, or remove it, as needed.
            this.prescriptionn_TableAdapter.Fill(this.dataSet11.Prescriptionn_);
            // TODO: This line of code loads data into the 'dataSet11.MedicationAdministration' table. You can move, or remove it, as needed.
            this.medicationAdministrationTableAdapter.Fill(this.dataSet11.MedicationAdministration);

        }
    }
}
