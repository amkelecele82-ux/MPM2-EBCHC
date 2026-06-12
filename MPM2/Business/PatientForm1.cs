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

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            RegPatientForm2 regPatientForm2 = new RegPatientForm2();
            regPatientForm2.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Force the grid to lock in whatever the user was currently typing
                dgvPatient.EndEdit();

                // Note: If you dragged and dropped your grid from the Data Sources panel, 
                // you likely have a BindingSource. Uncomment the line below if you have it:
                // patientBindingSource.EndEdit();

                // 2. The Magic Line: Send all modified rows in the grid directly to SQL Server
               patientTableAdapter.Update(this.dataSet1.Patient);

                // 3. Let the user know it worked
                MessageBox.Show("All changes to patient records have been saved successfully!",
                                "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not save changes to the database:\n\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      //  private void button1_Click(object sender, EventArgs e)
       // {
          
       // }

      //  private void button2_Click(object sender, EventArgs e)
        //{

      //  }
    }
}
