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
    public partial class AccountSettingsForm : Form
    {
        string userName;
        string fullName;
        public AccountSettingsForm(string userName, string fullName)
        {
            InitializeComponent();
            this.userName = userName;
            this.fullName = fullName;
        }

        private void AccountSettingsForm_Load(object sender, EventArgs e)
        {
            lblName.Text = fullName;
            lblUsername.Text = "@" + userName;
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            doctorTableAdapter1.UpdatePassword(TBPassword.Text.ToString(),1);
        }
    }
}
