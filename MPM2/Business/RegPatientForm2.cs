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
    public partial class RegPatientForm2 : Form
    {
        public RegPatientForm2()
        {
            InitializeComponent();
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

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();
                else if (ctrl is ComboBox cb)
                    cb.SelectedIndex = -1;
                else if (ctrl is DateTimePicker dtp)
                    dtp.Value = DateTime.Today;
            }
            errorProvider1.Clear();
        }
        private bool IsFieldValid(Control control, string fieldName, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, $"{fieldName} is required.");
                return false;
            }
            errorProvider.SetError(control, "");
            return true;
        }
        private bool IsValidSAID(string idNumber)
        {
            // Remove any spaces or dashes
            idNumber = idNumber.Trim().Replace(" ", "").Replace("-", "");

            // Check length (13 digits for SA ID)
            if (idNumber.Length != 13)
                return false;

            // Check if all characters are digits
            if (!idNumber.All(char.IsDigit))
                return false;

            // Optional: Luhn algorithm checksum validation for SA ID
            return IsValidSALuhn(idNumber);
        }

        private bool IsValidSALuhn(string id)
        {
            int total = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = int.Parse(id[i].ToString());
                if (i % 2 == 0)
                    total += digit;
                else
                {
                    int doubled = digit * 2;
                    total += (doubled / 10) + (doubled % 10);
                }
            }
            int checksum = (10 - (total % 10)) % 10;
            return checksum == int.Parse(id[12].ToString());
        }
        private bool IsValidCellPhone(string phone)
        {
            phone = phone.Trim().Replace(" ", "").Replace("-", "");
            // Accept 10-digit numbers starting with 0, or +27...
            if (phone.StartsWith("+27"))
                phone = "0" + phone.Substring(3);
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0[6-8][0-9]{8}$");
        }
        private bool IsValidDOB(DateTime dob)
        {
            if (dob > DateTime.Today)
                return false;
            // Optional: minimum age 0, maximum 120
            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age)) age--;
            return age >= 0 && age <= 120;
        }
        private bool IsValidPostalCode(string code)
        {
            code = code.Trim();
            return System.Text.RegularExpressions.Regex.IsMatch(code, @"^\d{4}$");
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            ErrorProvider ep = new ErrorProvider();

            // Required fields
            isValid &= IsFieldValid(txtIDNumber, "ID/Passport", ep);
            isValid &= IsFieldValid(txtSurname, "Surname", ep);
            isValid &= IsFieldValid(txtFirstNames, "First name(s)", ep);
            isValid &= IsFieldValid(txtAddress, "House number and street name", ep);
            isValid &= IsFieldValid(txtTownCity, "Town/City", ep);
            isValid &= IsFieldValid(textBox5, "Postal Code", ep);
            isValid &= IsFieldValid(txtPhone, "Cell phone number", ep);

            // Gender combo box
            if (cmbGender.SelectedIndex == -1)
            {
                ep.SetError(cmbGender, "Gender is required.");
                isValid = false;
            }
            else
                ep.SetError(cmbGender, "");

            // ID format 
            if (!string.IsNullOrWhiteSpace(txtIDNumber.Text) && txtIDNumber.Text.All(char.IsDigit))
            {
                if (!IsValidSAID(txtIDNumber.Text))
                {
                    ep.SetError(txtIDNumber, "Invalid South African ID number.");
                    isValid = false;
                }
            }

            // Date of birth
            if (!IsValidDOB(dtpDOB.Value))
            {
                ep.SetError(dtpDOB, "Date of birth cannot be in the future or unrealistic.");
                isValid = false;
            }
            else
                ep.SetError(dtpDOB, "");

            // Cell phone format
            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && !IsValidCellPhone(txtPhone.Text))
            {
                ep.SetError(txtPhone, "Invalid cell phone number. Format: 0812345678 or +27...");
                isValid = false;
            }

            // Postal code
            if (!IsValidPostalCode(textBox5.Text))
            {
                ep.SetError(textBox5, "Postal code must be 4 digits.");
                isValid = false;
            }

            return isValid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                
                MessageBox.Show("Validation passed. Saving patient...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            else
            {
                MessageBox.Show("Please correct the errors marked in red.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidSAID(txtIDNumber.Text))
                errorProvider1.SetError(txtIDNumber, "ID Number must be 13 digits and valid");
            else
                errorProvider1.SetError(txtIDNumber, "");

        }

        private void RegPatientForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
