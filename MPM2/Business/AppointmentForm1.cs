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
    public partial class AppointmentForm1 : Form
    {
        public AppointmentForm1()
        {
            InitializeComponent();
        }

        private void AppointmentForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.dataSet1.Appointment);

        }
    }
}
