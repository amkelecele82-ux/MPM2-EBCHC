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
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);

        }
    }
}
