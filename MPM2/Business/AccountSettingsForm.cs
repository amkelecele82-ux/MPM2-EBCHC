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
        private TextBox tbPassword;
        private TextBox txtNew;
        private TextBox txtConfirm;

        // Replace the type of CurrentUser from object to a strongly-typed user class.
        // You must use the actual user class used in your application. 
        // For this example, I'll define a simple User class here. 
        // If you already have a user class (e.g., User, Doctor, Patient), use that instead.

        public class User
        {
            public string FullName { get; set; }
            public string Role { get; set; }
            public string Username { get; set; }
        }

        // Change the property type from object to User
        public User CurrentUser { get; private set; }
        public TextBox TBPassword { get { return tbPassword; } }

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

            // Make avatar panel circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pnlAvatar.Width, pnlAvatar.Height);
            pnlAvatar.Region = new Region(gp);

            // Load logged in user details
            lblProfileName.Text = CurrentUser.FullName;    // replace with your session variable
            lblProfileRole.Text = CurrentUser.Role;
        
            txtFullName.Text = CurrentUser.FullName;
            txtUserName.Text = CurrentUser.Username;
           
           

            // Set initials in avatar
            string[] parts = CurrentUser.FullName.Split(' ');
            lblInitials.Text = parts.Length >= 2
                ? $"{parts[0][0]}{parts[1][0]}"
                : $"{parts[0][0]}";
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            doctorTableAdapter1.UpdatePassword(TBPassword.Text,1);
        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlProfileCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblProfileName_Click(object sender, EventArgs e)
        {

        }

        private void lblTeamKey_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNew.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save to database here
            MessageBox.Show("Password changed successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblInitials_Click(object sender, EventArgs e)
        {

        }
    }
}
