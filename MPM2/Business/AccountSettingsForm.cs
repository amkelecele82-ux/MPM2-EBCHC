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
        string role;
        int pk;
        public AccountSettingsForm(string role,DataRow dataRow)
        {
            InitializeComponent();
            this.userName = dataRow["Username"].ToString();
            this.fullName = dataRow["FullName"].ToString();
            this.role = role;
            if (role == "Patient")
            {
                pk = Convert.ToInt32(dataRow["PatientID"]);
            }
            if (role == "Doctor")
            {
                pk = Convert.ToInt32(dataRow["DoctorID"]);
            }
            if (role == "Nurse")
            {
                pk = Convert.ToInt32(dataRow["NurseID"]);
            }
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
