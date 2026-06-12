using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2.Business
{
    public partial class RegPatientForm2 : Form
    {
        public RegPatientForm2()
        {
            InitializeComponent();
            AttachValidationEvents();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void lblFolderNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblMarital_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void AttachValidationEvents()
        {
           
            txtSurname.TextChanged += txtSurname_TextChanged;
            txtFirstNames.TextChanged += txtFirstNames_TextChanged;
            txtIDNumber.TextChanged += txtIDNumber_TextChanged;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtTownCity.TextChanged += txtTownCity_TextChanged;
            txtPostal.TextChanged += txtPostal_TextChanged;
            txtNextofkinPhoneNo.TextChanged += txtNextofkinPhoneNo_TextChanged;

            
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;

            
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;
        }


        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
                errorProvider1.SetError(txtSurname, "Surname is required.");
            else
                errorProvider1.SetError(txtSurname, "");
        }

        private void txtFirstNames_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstNames.Text))
                errorProvider1.SetError(txtFirstNames, "First name(s) is required.");
            else
                errorProvider1.SetError(txtFirstNames, "");
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            string id = txtIDNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(id))
                errorProvider1.SetError(txtIDNumber, "ID number is required.");
            else if (!IsValidSAID(id))
                errorProvider1.SetError(txtIDNumber, "Invalid SA ID (13 digits, valid checksum)");
            else
                errorProvider1.SetError(txtIDNumber, "");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
                errorProvider1.SetError(txtPhone, "Cell phone number is required.");
            else if (!IsValidCellPhone(phone))
                errorProvider1.SetError(txtPhone, "Invalid cell number (e.g., 0812345678)");
            else
                errorProvider1.SetError(txtPhone, "");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
                errorProvider1.SetError(txtEmail, "Email address is required.");
            else if (!IsValidEmail(email))
                errorProvider1.SetError(txtEmail, "Invalid email format (e.g., name@example.com)");
            else
                errorProvider1.SetError(txtEmail, "");
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                errorProvider1.SetError(txtAddress, "House/Street is required.");
            else
                errorProvider1.SetError(txtAddress, "");
        }

        private void txtTownCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTownCity.Text))
                errorProvider1.SetError(txtTownCity, "Town/City is required.");
            else
                errorProvider1.SetError(txtTownCity, "");
        }

        private void txtPostal_TextChanged(object sender, EventArgs e)
        {
            string code = txtPostal.Text.Trim();
            if (string.IsNullOrWhiteSpace(code))
                errorProvider1.SetError(txtPostal, "Postal code is required.");
            else if (!IsValidPostalCode(code))
                errorProvider1.SetError(txtPostal, "Postal code must be 4 digits.");
            else
                errorProvider1.SetError(txtPostal, "");
        }

        private void txtNextofkinPhoneNo_TextChanged(object sender, EventArgs e)
        {
            string phone = txtNextofkinPhoneNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
                errorProvider1.SetError(txtNextofkinPhoneNo, "");
            else if (!IsValidCellPhone(phone))
                errorProvider1.SetError(txtNextofkinPhoneNo, "Invalid cell number for next of kin");
            else
                errorProvider1.SetError(txtNextofkinPhoneNo, "");
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
                errorProvider1.SetError(cmbGender, "Gender is required.");
            else
                errorProvider1.SetError(cmbGender, "");
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            if (!IsValidDOB(dtpDOB.Value))
                errorProvider1.SetError(dtpDOB, "Invalid date of birth (cannot be in future or too old).");
            else
                errorProvider1.SetError(dtpDOB, "");
        }

       
        private bool IsValidSAID(string id)
        {
            id = id.Trim().Replace(" ", "").Replace("-", "");
            if (id.Length != 13) return false;
            return id.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }

        private bool IsValidCellPhone(string phone)
        {
            phone = phone.Trim().Replace(" ", "").Replace("-", "");
            if (phone.StartsWith("+27")) phone = "0" + phone.Substring(3);
            return Regex.IsMatch(phone, @"^0[6-8][0-9]{8}$");
        }

        private bool IsValidDOB(DateTime dob)
        {
            if (dob > DateTime.Today) return false;
            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age)) age--;
            return age >= 0 && age <= 120;
        }

        private bool IsValidPostalCode(string code)
        {
            return Regex.IsMatch(code.Trim(), @"^\d{4}$");
        }

       
        private bool ValidateForm()
        {
            bool isValid = true;

            // Required fields
            isValid &= !string.IsNullOrWhiteSpace(txtSurname.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtFirstNames.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtIDNumber.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtPhone.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtEmail.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtAddress.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtTownCity.Text);
            isValid &= !string.IsNullOrWhiteSpace(txtPostal.Text);
            isValid &= (cmbGender.SelectedIndex != -1);
            isValid &= IsValidDOB(dtpDOB.Value);

            
            if (!IsValidSAID(txtIDNumber.Text.Trim())) isValid = false;
            if (!IsValidEmail(txtEmail.Text.Trim())) isValid = false;
            if (!IsValidCellPhone(txtPhone.Text.Trim())) isValid = false;
            if (!IsValidPostalCode(txtPostal.Text.Trim())) isValid = false;
            if (!string.IsNullOrWhiteSpace(txtNextofkinPhoneNo.Text) && !IsValidCellPhone(txtNextofkinPhoneNo.Text)) isValid = false;

            // Trigger real-time errors to show if any field is invalid
            txtSurname_TextChanged(null, null);
            txtFirstNames_TextChanged(null, null);
            txtIDNumber_TextChanged(null, null);
            txtPhone_TextChanged(null, null);
            txtEmail_TextChanged(null, null);
            txtAddress_TextChanged(null, null);
            txtTownCity_TextChanged(null, null);
            txtPostal_TextChanged(null, null);
            cmbGender_SelectedIndexChanged(null, null);
            dtpDOB_ValueChanged(null, null);
            txtNextofkinPhoneNo_TextChanged(null, null);

            return isValid;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
         
            if (!ValidateForm())
            {
                MessageBox.Show("Please correct the highlighted errors before registering the patient.",
                                "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                
                string idNumber = txtIDNumber.Text.Trim();

               
                int existingPatients = (int)patientTableAdapter1.CheckIfPatientExist(idNumber);

                if (existingPatients > 0)
                {
                    MessageBox.Show("A patient with this ID Number/Passport is already registered in the system.",
                                    "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit immediately if it's a duplicate
                }

            
                string fullName = $"{txtFirstNames.Text.Trim()} {txtSurname.Text.Trim()}";
                string address = $"{txtAddress.Text.Trim()}, {txtSub.Text.Trim()}, {txtTownCity.Text.Trim()}, {txtPostal.Text.Trim()}";


                patientTableAdapter1.InsertPQ(
                    fullName,
                    dtpDOB.Text,
                    txtPhone.Text.Trim(),
                    address,
                    txtEmail.Text.Trim(),
                    null, // Alternative Phone Number (Allowed to be null)
                    txtFolderNumber.Text.Trim(),
                    idNumber,
                    cmbReligion.Text,
                    cmbLanguage.Text,
                    cmbMarital.Text,
                    txtNextofkinName.Text.Trim(),
                    txtNextofkinPhoneNo.Text.Trim(),
                    cmbGender.Text
                );

                // ==========================================
                // 5. SUCCESS
                // ==========================================
                MessageBox.Show("Patient registered successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tip: You might want to call a method here to clear the form fields
                // ClearFormFields(); 
            }
            catch (Exception ex)
            {
                // ==========================================
                // 6. ERROR HANDLING
                // ==========================================
                MessageBox.Show($"An error occurred while saving the patient:\n\n{ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt) txt.Clear();
                else if (ctrl is ComboBox cb) cb.SelectedIndex = -1;
                else if (ctrl is DateTimePicker dtp) dtp.Value = DateTime.Today;
            }
            errorProvider1.Clear();
        }
    }
}
