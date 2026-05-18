namespace MPM2.Business
{
    partial class PatientForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.patientTableAdapter = new MPM2.Database.DataSet1TableAdapters.PatientTableAdapter();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPatient
            // 
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatient.AutoGenerateColumns = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.alternativePhoneNumberDataGridViewTextBoxColumn});
            this.dgvPatient.DataSource = this.patientBindingSource;
            this.dgvPatient.Location = new System.Drawing.Point(82, 125);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.Size = new System.Drawing.Size(1429, 696);
            this.dgvPatient.TabIndex = 1;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // alternativePhoneNumberDataGridViewTextBoxColumn
            // 
            this.alternativePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "AlternativePhoneNumber";
            this.alternativePhoneNumberDataGridViewTextBoxColumn.HeaderText = "AlternativePhoneNumber";
            this.alternativePhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alternativePhoneNumberDataGridViewTextBoxColumn.Name = "alternativePhoneNumberDataGridViewTextBoxColumn";
            this.alternativePhoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient name:";
            // 
            // TBPName
            // 
            this.TBPName.Location = new System.Drawing.Point(593, 14);
            this.TBPName.Name = "TBPName";
            this.TBPName.Size = new System.Drawing.Size(229, 22);
            this.TBPName.TabIndex = 3;
            this.TBPName.TextChanged += new System.EventHandler(this.TBPName_TextChanged_1);
            // 
            // PatientForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPName);
            this.Controls.Add(this.dgvPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm1";
            this.Text = "PatientForm1";
            this.Load += new System.EventHandler(this.PatientForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Database.DataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativePhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPName;
    }
}