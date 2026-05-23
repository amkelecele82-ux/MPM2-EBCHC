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
    public partial class RegPatientForm : Form
    {
        public RegPatientForm()
        {
            InitializeComponent();
        }

        private void TPDetails_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The following information is \n " + TBFname.Text + " " + TBLname.Text + "\n" + TBStreetAddress.Text + "\n" + TBCity.Text + "\n" + TBPhoneNo.Text + "\n" + TBAltPhoneNo.Text + "\n" + TBUsername.Text + "\n" + TBPassword.Text + "\n" + DTPDOB.Value.ToShortDateString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Patient Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            TBStreetAddress.Clear();
            TBAltPhoneNo.Clear();
            TBPhoneNo.Clear();
            TBCity.Clear();
            TBFname.Clear();
            TBLname.Clear();
            TBUsername.Clear();
            TBPassword.Clear();
            DTPDOB.Value = DateTime.Today;
        }
    }
}
