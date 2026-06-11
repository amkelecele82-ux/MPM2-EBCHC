namespace MPM2.Business
{
    partial class AccountSettingsForm
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
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.doctorTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.DoctorTableAdapter();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKZN = new System.Windows.Forms.Label();
            this.pnlSecureBar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedTextBox3 = new RoundedTextBox();
            this.txtUserName = new RoundedTextBox();
            this.txtFullName = new RoundedTextBox();
            this.pnlProfileCard = new RoundedPanel();
            this.lblTeamVal = new System.Windows.Forms.Label();
            this.lblTeamKey = new System.Windows.Forms.Label();
            this.lblLoginVal = new System.Windows.Forms.Label();
            this.lblLoginKey = new System.Windows.Forms.Label();
            this.lblStatusVal = new System.Windows.Forms.Label();
            this.lblStatusKey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStaffNo = new System.Windows.Forms.Label();
            this.lblProfileRole = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblInitials = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSecureBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Location = new System.Drawing.Point(430, 418);
            this.ChangePassButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(79, 32);
            this.ChangePassButton.TabIndex = 16;
            this.ChangePassButton.Text = "Change";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(410, 222);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 17);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(410, 146);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.lblKZN);
            this.pnlTitleBar.Location = new System.Drawing.Point(1, 1);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1651, 38);
            this.pnlTitleBar.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Account Settings — East Boom CHC";
            // 
            // lblKZN
            // 
            this.lblKZN.AutoSize = true;
            this.lblKZN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(59)))), ((int)(((byte)(26)))));
            this.lblKZN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKZN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(164)))));
            this.lblKZN.Location = new System.Drawing.Point(10, 9);
            this.lblKZN.Name = "lblKZN";
            this.lblKZN.Size = new System.Drawing.Size(57, 13);
            this.lblKZN.TabIndex = 0;
            this.lblKZN.Text = "KZN DOH";
            // 
            // pnlSecureBar
            // 
            this.pnlSecureBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(59)))), ((int)(((byte)(26)))));
            this.pnlSecureBar.Controls.Add(this.label7);
            this.pnlSecureBar.Location = new System.Drawing.Point(1, 38);
            this.pnlSecureBar.Name = "pnlSecureBar";
            this.pnlSecureBar.Size = new System.Drawing.Size(1651, 22);
            this.pnlSecureBar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(119)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(705, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "AUTHORISED PERSONNEL ONLY — SECURE SYSTEM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(1, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1661, 29);
            this.panel2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label9.Location = new System.Drawing.Point(1264, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Clinic Management System · East Boom Community Health Centre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(16, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Account Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(410, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "PERSONAL INFORMATION";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.panel4.Location = new System.Drawing.Point(413, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 1);
            this.panel4.TabIndex = 15;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Controls.Add(this.btnLogout);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Location = new System.Drawing.Point(1, 775);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1698, 48);
            this.pnlFooter.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(409, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " M2 Version · June 2026 · Synergy Seekers";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.Location = new System.Drawing.Point(252, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.Location = new System.Drawing.Point(162, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(32, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.pnlStatusBar.Controls.Add(this.label4);
            this.pnlStatusBar.Controls.Add(this.label2);
            this.pnlStatusBar.Location = new System.Drawing.Point(1, 822);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(1651, 24);
            this.pnlStatusBar.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(384, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "East Boom CHC · KZN DoH · 11 May 2026";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(33, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Account Settings · Patient Management System v2.1.4";
            // 
            // roundedTextBox3
            // 
            this.roundedTextBox3.BackColor = System.Drawing.Color.White;
            this.roundedTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.roundedTextBox3.CornerRadius = 8;
            this.roundedTextBox3.IsPassword = false;
            this.roundedTextBox3.Location = new System.Drawing.Point(413, 313);
            this.roundedTextBox3.Name = "roundedTextBox3";
            this.roundedTextBox3.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.roundedTextBox3.PasswordChar = '\0';
            this.roundedTextBox3.Size = new System.Drawing.Size(310, 36);
            this.roundedTextBox3.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.txtUserName.CornerRadius = 8;
            this.txtUserName.IsPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(413, 242);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.Size = new System.Drawing.Size(310, 36);
            this.txtUserName.TabIndex = 17;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.txtFullName.CornerRadius = 8;
            this.txtFullName.IsPassword = false;
            this.txtFullName.Location = new System.Drawing.Point(413, 166);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Size = new System.Drawing.Size(310, 36);
            this.txtFullName.TabIndex = 16;
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.pnlProfileCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfileCard.Controls.Add(this.lblTeamVal);
            this.pnlProfileCard.Controls.Add(this.lblTeamKey);
            this.pnlProfileCard.Controls.Add(this.lblLoginVal);
            this.pnlProfileCard.Controls.Add(this.lblLoginKey);
            this.pnlProfileCard.Controls.Add(this.lblStatusVal);
            this.pnlProfileCard.Controls.Add(this.lblStatusKey);
            this.pnlProfileCard.Controls.Add(this.panel3);
            this.pnlProfileCard.Controls.Add(this.lblStaffNo);
            this.pnlProfileCard.Controls.Add(this.lblProfileRole);
            this.pnlProfileCard.Controls.Add(this.lblProfileName);
            this.pnlProfileCard.Controls.Add(this.pnlAvatar);
            this.pnlProfileCard.CornerRadius = 20;
            this.pnlProfileCard.Location = new System.Drawing.Point(35, 146);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Size = new System.Drawing.Size(317, 374);
            this.pnlProfileCard.TabIndex = 13;
            this.pnlProfileCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProfileCard_Paint);
            // 
            // lblTeamVal
            // 
            this.lblTeamVal.AutoSize = true;
            this.lblTeamVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.lblTeamVal.Location = new System.Drawing.Point(103, 280);
            this.lblTeamVal.Name = "lblTeamVal";
            this.lblTeamVal.Size = new System.Drawing.Size(91, 15);
            this.lblTeamVal.TabIndex = 10;
            this.lblTeamVal.Text = "Synergy Seekers";
            // 
            // lblTeamKey
            // 
            this.lblTeamKey.AutoSize = true;
            this.lblTeamKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.lblTeamKey.Location = new System.Drawing.Point(15, 280);
            this.lblTeamKey.Name = "lblTeamKey";
            this.lblTeamKey.Size = new System.Drawing.Size(36, 15);
            this.lblTeamKey.TabIndex = 9;
            this.lblTeamKey.Text = "Team";
            this.lblTeamKey.Click += new System.EventHandler(this.lblTeamKey_Click);
            // 
            // lblLoginVal
            // 
            this.lblLoginVal.AutoSize = true;
            this.lblLoginVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.lblLoginVal.Location = new System.Drawing.Point(103, 243);
            this.lblLoginVal.Name = "lblLoginVal";
            this.lblLoginVal.Size = new System.Drawing.Size(72, 15);
            this.lblLoginVal.TabIndex = 8;
            this.lblLoginVal.Text = "11 May 2026";
            // 
            // lblLoginKey
            // 
            this.lblLoginKey.AutoSize = true;
            this.lblLoginKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.lblLoginKey.Location = new System.Drawing.Point(15, 243);
            this.lblLoginKey.Name = "lblLoginKey";
            this.lblLoginKey.Size = new System.Drawing.Size(58, 15);
            this.lblLoginKey.TabIndex = 7;
            this.lblLoginKey.Text = "Last login";
            // 
            // lblStatusVal
            // 
            this.lblStatusVal.AutoSize = true;
            this.lblStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.lblStatusVal.Location = new System.Drawing.Point(108, 206);
            this.lblStatusVal.Name = "lblStatusVal";
            this.lblStatusVal.Size = new System.Drawing.Size(50, 15);
            this.lblStatusVal.TabIndex = 6;
            this.lblStatusVal.Text = "● Active";
            // 
            // lblStatusKey
            // 
            this.lblStatusKey.AutoSize = true;
            this.lblStatusKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(136)))));
            this.lblStatusKey.Location = new System.Drawing.Point(15, 206);
            this.lblStatusKey.Name = "lblStatusKey";
            this.lblStatusKey.Size = new System.Drawing.Size(39, 15);
            this.lblStatusKey.TabIndex = 5;
            this.lblStatusKey.Text = "Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.panel3.Location = new System.Drawing.Point(33, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.AutoSize = true;
            this.lblStaffNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblStaffNo.Location = new System.Drawing.Point(62, 160);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(96, 15);
            this.lblStaffNo.TabIndex = 3;
            this.lblStaffNo.Text = "KZN-DOH-00412\n";
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.AutoSize = true;
            this.lblProfileRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.lblProfileRole.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(63)))));
            this.lblProfileRole.Location = new System.Drawing.Point(62, 139);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(96, 13);
            this.lblProfileRole.TabIndex = 2;
            this.lblProfileRole.Text = "Doctor / Clinician";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(59)))), ((int)(((byte)(26)))));
            this.lblProfileName.Location = new System.Drawing.Point(62, 109);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(138, 17);
            this.lblProfileName.TabIndex = 1;
            this.lblProfileName.Text = "Nokukhanya Dlamini";
            this.lblProfileName.Click += new System.EventHandler(this.lblProfileName_Click);
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.pnlAvatar.Controls.Add(this.lblInitials);
            this.pnlAvatar.Location = new System.Drawing.Point(100, 20);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(72, 72);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.BackColor = System.Drawing.Color.Transparent;
            this.lblInitials.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitials.ForeColor = System.Drawing.Color.White;
            this.lblInitials.Location = new System.Drawing.Point(7, 19);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(51, 32);
            this.lblInitials.TabIndex = 1;
            this.lblInitials.Text = "ND";
            this.lblInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInitials.Click += new System.EventHandler(this.lblInitials_Click);
            // 
            // AccountSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(107)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1664, 968);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.roundedTextBox3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlProfileCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSecureBar);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 70);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountSettingsForm";
            this.Text = "AccountSettingsForm";
            this.Load += new System.EventHandler(this.AccountSettingsForm_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSecureBar.ResumeLayout(false);
            this.pnlSecureBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.pnlAvatar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private Database.DataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblKZN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSecureBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RoundedPanel pnlProfileCard;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileRole;
        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLoginVal;
        private System.Windows.Forms.Label lblLoginKey;
        private System.Windows.Forms.Label lblStatusVal;
        private System.Windows.Forms.Label lblStatusKey;
        private System.Windows.Forms.Label lblTeamVal;
        private System.Windows.Forms.Label lblTeamKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private RoundedTextBox txtFullName;
        private RoundedTextBox txtUserName;
        private RoundedTextBox roundedTextBox3;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}