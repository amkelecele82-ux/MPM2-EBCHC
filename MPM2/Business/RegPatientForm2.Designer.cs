namespace MPM2.Business
{
    partial class RegPatientForm2
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblKZNBadge = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnlSectionHeader = new System.Windows.Forms.Panel();
            this.lblSectionHeader = new System.Windows.Forms.Label();
            this.lblFolderNumber = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtFolderNumber = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMarital = new System.Windows.Forms.Label();
            this.cmbMarital = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMedicalAid = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.cmbMedicalAid = new System.Windows.Forms.ComboBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons2 = new System.Windows.Forms.Panel();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlSectionHeader.SuspendLayout();
            this.pnlButtons2.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.pnlTitleBar.Controls.Add(this.lblFormTitle);
            this.pnlTitleBar.Controls.Add(this.lblKZNBadge);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.MaximumSize = new System.Drawing.Size(0, 32);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1526, 32);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblKZNBadge
            // 
            this.lblKZNBadge.AutoSize = true;
            this.lblKZNBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(134)))), ((int)(((byte)(10)))));
            this.lblKZNBadge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKZNBadge.ForeColor = System.Drawing.Color.White;
            this.lblKZNBadge.Location = new System.Drawing.Point(8, 7);
            this.lblKZNBadge.Name = "lblKZNBadge";
            this.lblKZNBadge.Size = new System.Drawing.Size(57, 13);
            this.lblKZNBadge.TabIndex = 0;
            this.lblKZNBadge.Text = "KZN DOH";
            this.lblKZNBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(78, 7);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(275, 17);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "New patient registration — East Boom CHC";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.ItemSize = new System.Drawing.Size(128, 24);
            this.tabMain.Location = new System.Drawing.Point(0, 32);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1526, 26);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1518, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1518, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medical history";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1518, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chronic conditions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1518, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Next of kin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnlSectionHeader
            // 
            this.pnlSectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(30)))));
            this.pnlSectionHeader.Controls.Add(this.lblSectionHeader);
            this.pnlSectionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSectionHeader.Location = new System.Drawing.Point(0, 58);
            this.pnlSectionHeader.Name = "pnlSectionHeader";
            this.pnlSectionHeader.Size = new System.Drawing.Size(1526, 26);
            this.pnlSectionHeader.TabIndex = 3;
            // 
            // lblSectionHeader
            // 
            this.lblSectionHeader.AutoSize = true;
            this.lblSectionHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionHeader.ForeColor = System.Drawing.Color.White;
            this.lblSectionHeader.Location = new System.Drawing.Point(10, 5);
            this.lblSectionHeader.Name = "lblSectionHeader";
            this.lblSectionHeader.Size = new System.Drawing.Size(202, 15);
            this.lblSectionHeader.TabIndex = 0;
            this.lblSectionHeader.Text = "Personal & demographic information";
            // 
            // lblFolderNumber
            // 
            this.lblFolderNumber.AutoSize = true;
            this.lblFolderNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderNumber.Location = new System.Drawing.Point(12, 92);
            this.lblFolderNumber.Name = "lblFolderNumber";
            this.lblFolderNumber.Size = new System.Drawing.Size(130, 13);
            this.lblFolderNumber.TabIndex = 4;
            this.lblFolderNumber.Text = "Folder / patient number";
            this.lblFolderNumber.Click += new System.EventHandler(this.lblFolderNumber_Click);
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(548, 92);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(124, 13);
            this.lblIDNumber.TabIndex = 5;
            this.lblIDNumber.Text = "ID number / passport *";
            // 
            // txtFolderNumber
            // 
            this.txtFolderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txtFolderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtFolderNumber.Location = new System.Drawing.Point(12, 109);
            this.txtFolderNumber.Name = "txtFolderNumber";
            this.txtFolderNumber.Size = new System.Drawing.Size(524, 23);
            this.txtFolderNumber.TabIndex = 6;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.BackColor = System.Drawing.Color.White;
            this.txtIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtIDNumber.Location = new System.Drawing.Point(548, 109);
            this.txtIDNumber.MaxLength = 13;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(524, 23);
            this.txtIDNumber.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(548, 140);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First name(s) *";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(12, 140);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 13);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname *";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox1.Location = new System.Drawing.Point(548, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox2.Location = new System.Drawing.Point(12, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 23);
            this.textBox2.TabIndex = 11;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(548, 188);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender *";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(12, 188);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 13);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date of birth *";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy/MM/dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(12, 205);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(524, 23);
            this.dtpDOB.TabIndex = 14;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other / Not specified"});
            this.cmbGender.Location = new System.Drawing.Point(548, 205);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(524, 23);
            this.cmbGender.TabIndex = 15;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(12, 236);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(89, 13);
            this.lblLanguage.TabIndex = 16;
            this.lblLanguage.Text = "Home language";
            // 
            // lblMarital
            // 
            this.lblMarital.AutoSize = true;
            this.lblMarital.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarital.Location = new System.Drawing.Point(548, 236);
            this.lblMarital.Name = "lblMarital";
            this.lblMarital.Size = new System.Drawing.Size(77, 13);
            this.lblMarital.TabIndex = 17;
            this.lblMarital.Text = "Marital status";
            // 
            // cmbMarital
            // 
            this.cmbMarital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarital.FormattingEnabled = true;
            this.cmbMarital.Items.AddRange(new object[] {
            "Single",
            "",
            "Married",
            "",
            "Divorced",
            "",
            "Widowed"});
            this.cmbMarital.Location = new System.Drawing.Point(548, 253);
            this.cmbMarital.Name = "cmbMarital";
            this.cmbMarital.Size = new System.Drawing.Size(524, 23);
            this.cmbMarital.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "IsiZulu",
            "I",
            "siXhosa",
            "",
            "Afrikaans",
            "",
            "English",
            "",
            "Sesotho",
            "",
            "Setswana",
            "",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(12, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(524, 23);
            this.comboBox2.TabIndex = 19;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 284);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 13);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Residential address *";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtAddress.Location = new System.Drawing.Point(12, 301);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1060, 23);
            this.txtAddress.TabIndex = 21;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 332);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(106, 13);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Cell phone number";
            // 
            // lblMedicalAid
            // 
            this.lblMedicalAid.AutoSize = true;
            this.lblMedicalAid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalAid.Location = new System.Drawing.Point(548, 332);
            this.lblMedicalAid.Name = "lblMedicalAid";
            this.lblMedicalAid.Size = new System.Drawing.Size(114, 13);
            this.lblMedicalAid.TabIndex = 23;
            this.lblMedicalAid.Text = "Medical aid / scheme";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtPhone.Location = new System.Drawing.Point(12, 349);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(524, 23);
            this.txtPhone.TabIndex = 24;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txtComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtComplaint.Location = new System.Drawing.Point(12, 397);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(1060, 23);
            this.txtComplaint.TabIndex = 25;
            // 
            // cmbMedicalAid
            // 
            this.cmbMedicalAid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicalAid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedicalAid.FormattingEnabled = true;
            this.cmbMedicalAid.Items.AddRange(new object[] {
            "None / State patient",
            "",
            "Discovery Health",
            "",
            "Bonitas",
            "",
            "Medihelp",
            "",
            "Momentum",
            "",
            "Other"});
            this.cmbMedicalAid.Location = new System.Drawing.Point(548, 349);
            this.cmbMedicalAid.Name = "cmbMedicalAid";
            this.cmbMedicalAid.Size = new System.Drawing.Size(524, 23);
            this.cmbMedicalAid.TabIndex = 26;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(12, 380);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(202, 13);
            this.lblComplaint.TabIndex = 27;
            this.lblComplaint.Text = "Presenting complaint / reason for visit";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 790);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1526, 44);
            this.pnlButtons.TabIndex = 28;
            // 
            // pnlButtons2
            // 
            this.pnlButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.pnlButtons2.Controls.Add(this.btnNext);
            this.pnlButtons2.Controls.Add(this.btnSaveDraft);
            this.pnlButtons2.Controls.Add(this.btnRegister);
            this.pnlButtons2.Controls.Add(this.btnClearForm);
            this.pnlButtons2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons2.Location = new System.Drawing.Point(0, 730);
            this.pnlButtons2.Name = "pnlButtons2";
            this.pnlButtons2.Size = new System.Drawing.Size(1526, 60);
            this.pnlButtons2.TabIndex = 29;
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.White;
            this.btnClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClearForm.Location = new System.Drawing.Point(754, 8);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(90, 28);
            this.btnClearForm.TabIndex = 0;
            this.btnClearForm.Text = "Clear form";
            this.btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(107)))), ((int)(((byte)(42)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1120, 8);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 28);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register & save";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.BackColor = System.Drawing.Color.White;
            this.btnSaveDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSaveDraft.Location = new System.Drawing.Point(852, 8);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(90, 28);
            this.btnSaveDraft.TabIndex = 2;
            this.btnSaveDraft.Text = "Save draft";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(134)))), ((int)(((byte)(10)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(950, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next — Medical history";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(18)))));
            this.pnlStatusBar.Controls.Add(this.lblStatusRight);
            this.pnlStatusBar.Controls.Add(this.lblStatusLeft);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 708);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(1526, 22);
            this.pnlStatusBar.TabIndex = 30;
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(208)))), ((int)(((byte)(138)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(8, 4);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(235, 13);
            this.lblStatusLeft.TabIndex = 0;
            this.lblStatusLeft.Text = "New registration  ·  Required fields marked *";
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(208)))), ((int)(((byte)(138)))));
            this.lblStatusRight.Location = new System.Drawing.Point(850, 4);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(190, 13);
            this.lblStatusRight.TabIndex = 1;
            this.lblStatusRight.Text = "Nurse: Sr. N. Dlamini  ·  11 May 2026";
            // 
            // RegPatientForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1526, 834);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlButtons2);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblComplaint);
            this.Controls.Add(this.cmbMedicalAid);
            this.Controls.Add(this.txtComplaint);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblMedicalAid);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbMarital);
            this.Controls.Add(this.lblMarital);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtFolderNumber);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblFolderNumber);
            this.Controls.Add(this.pnlSectionHeader);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegPatientForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration Form";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.pnlSectionHeader.ResumeLayout(false);
            this.pnlSectionHeader.PerformLayout();
            this.pnlButtons2.ResumeLayout(false);
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblKZNBadge;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel pnlSectionHeader;
        private System.Windows.Forms.Label lblSectionHeader;
        private System.Windows.Forms.Label lblFolderNumber;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtFolderNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblMarital;
        private System.Windows.Forms.ComboBox cmbMarital;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMedicalAid;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.ComboBox cmbMedicalAid;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlButtons2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblStatusRight;
        private System.Windows.Forms.Label lblStatusLeft;
    }
}