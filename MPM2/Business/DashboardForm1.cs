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
    public partial class DashboardForm1 : Form
    {
        string userName;
        string fullName;
        string role;
        public DashboardForm1(string userName, string fullName, string role)
        {
            InitializeComponent();
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
        }

        private void DashboardForm1_Load(object sender, EventArgs e)
        {
            fullNameLabel.Text = fullName;

        }
    }
}
