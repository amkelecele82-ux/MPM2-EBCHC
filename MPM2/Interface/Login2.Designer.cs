namespace MPM2.Interface
{
    partial class Login2
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
            this.dataSet11 = new MPM2.Database.DataSet1();
            this.roundedPanel = new RoundedPanel();
            this.roleNurse = new RoleCard();
            this.roleAdmin = new RoleCard();
            this.rolePatient = new RoleCard();
            this.roleDoctor = new RoleCard();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelFootBar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ButtonSignIn = new RoundedButton();
            this.TBPassword = new RoundedTextBox();
            this.TBUsername = new RoundedTextBox();
            this.pnlSecureBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.titlelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Provincelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.DoctorTableAdapter();
            this.nurseTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.NurseTableAdapter();
            this.administratorTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.AdministratorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.roundedPanel.SuspendLayout();
            this.panelFootBar.SuspendLayout();
            this.pnlSecureBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roundedPanel
            // 
            this.roundedPanel.BackColor = System.Drawing.Color.White;
            this.roundedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel.Controls.Add(this.roleNurse);
            this.roundedPanel.Controls.Add(this.roleAdmin);
            this.roundedPanel.Controls.Add(this.rolePatient);
            this.roundedPanel.Controls.Add(this.roleDoctor);
            this.roundedPanel.Controls.Add(this.linkLabel1);
            this.roundedPanel.Controls.Add(this.panelFootBar);
            this.roundedPanel.Controls.Add(this.linkLabel2);
            this.roundedPanel.Controls.Add(this.ButtonSignIn);
            this.roundedPanel.Controls.Add(this.TBPassword);
            this.roundedPanel.Controls.Add(this.TBUsername);
            this.roundedPanel.Controls.Add(this.pnlSecureBar);
            this.roundedPanel.Controls.Add(this.checkBoxRemember);
            this.roundedPanel.Controls.Add(this.labelPassword);
            this.roundedPanel.Controls.Add(this.labelUsername);
            this.roundedPanel.Controls.Add(this.pnlHeader);
            this.roundedPanel.Controls.Add(this.label2);
            this.roundedPanel.CornerRadius = 8;
            this.roundedPanel.Location = new System.Drawing.Point(414, 44);
            this.roundedPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.Size = new System.Drawing.Size(778, 659);
            this.roundedPanel.TabIndex = 18;
            // 
            // roleNurse
            // 
            this.roleNurse.BackColor = System.Drawing.Color.White;
            this.roleNurse.CornerRadius = 10;
            this.roleNurse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleNurse.Icon = null;
            this.roleNurse.Location = new System.Drawing.Point(365, 155);
            this.roleNurse.Name = "roleNurse";
            this.roleNurse.Padding = new System.Windows.Forms.Padding(10);
            this.roleNurse.Selected = false;
            this.roleNurse.Size = new System.Drawing.Size(210, 58);
            this.roleNurse.SubTitle = "Vitals & triage";
            this.roleNurse.TabIndex = 20;
            this.roleNurse.Title = "Nurse / sister";
            this.roleNurse.Load += new System.EventHandler(this.roleNurse_Load);
            // 
            // roleAdmin
            // 
            this.roleAdmin.BackColor = System.Drawing.Color.White;
            this.roleAdmin.CornerRadius = 10;
            this.roleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleAdmin.Icon = null;
            this.roleAdmin.Location = new System.Drawing.Point(362, 229);
            this.roleAdmin.Name = "roleAdmin";
            this.roleAdmin.Padding = new System.Windows.Forms.Padding(10);
            this.roleAdmin.Selected = false;
            this.roleAdmin.Size = new System.Drawing.Size(210, 58);
            this.roleAdmin.SubTitle = "Full system access";
            this.roleAdmin.TabIndex = 21;
            this.roleAdmin.Title = "Administrator";
            this.roleAdmin.Load += new System.EventHandler(this.roleAdmin_Load);
            // 
            // rolePatient
            // 
            this.rolePatient.BackColor = System.Drawing.Color.White;
            this.rolePatient.CornerRadius = 10;
            this.rolePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rolePatient.Icon = null;
            this.rolePatient.Location = new System.Drawing.Point(115, 229);
            this.rolePatient.Name = "rolePatient";
            this.rolePatient.Padding = new System.Windows.Forms.Padding(10);
            this.rolePatient.Selected = false;
            this.rolePatient.Size = new System.Drawing.Size(210, 58);
            this.rolePatient.SubTitle = "Book Appointment";
            this.rolePatient.TabIndex = 20;
            this.rolePatient.Title = "Patient";
            this.rolePatient.Load += new System.EventHandler(this.rolePatient_Load);
            // 
            // roleDoctor
            // 
            this.roleDoctor.BackColor = System.Drawing.Color.White;
            this.roleDoctor.CornerRadius = 10;
            this.roleDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleDoctor.Icon = null;
            this.roleDoctor.Location = new System.Drawing.Point(115, 155);
            this.roleDoctor.Name = "roleDoctor";
            this.roleDoctor.Padding = new System.Windows.Forms.Padding(10);
            this.roleDoctor.Selected = false;
            this.roleDoctor.Size = new System.Drawing.Size(210, 58);
            this.roleDoctor.SubTitle = "Full clinical access";
            this.roleDoctor.TabIndex = 19;
            this.roleDoctor.Title = "Doctor / clinician";
            this.roleDoctor.Load += new System.EventHandler(this.roleDoctor_Load);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.linkLabel1.Location = new System.Drawing.Point(190, 552);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 19);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            // 
            // panelFootBar
            // 
            this.panelFootBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.panelFootBar.Controls.Add(this.label6);
            this.panelFootBar.Controls.Add(this.label5);
            this.panelFootBar.Controls.Add(this.label4);
            this.panelFootBar.Location = new System.Drawing.Point(-1, 590);
            this.panelFootBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFootBar.Name = "panelFootBar";
            this.panelFootBar.Size = new System.Drawing.Size(782, 69);
            this.panelFootBar.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(191, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(510, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Protected Under the National Health Act & POPIA. Authorized personnel only.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "🔒 Secure & encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "East Boom CHC · KZN DoH · 11 May 2026";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.linkLabel2.Location = new System.Drawing.Point(444, 552);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 19);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Help";
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.ButtonSignIn.CornerRadius = 8;
            this.ButtonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignIn.FlatAppearance.BorderSize = 0;
            this.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.ButtonSignIn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.ButtonSignIn.Location = new System.Drawing.Point(115, 495);
            this.ButtonSignIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.ButtonSignIn.Size = new System.Drawing.Size(460, 44);
            this.ButtonSignIn.TabIndex = 15;
            this.ButtonSignIn.Text = "Sign in to system";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.White;
            this.TBPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.TBPassword.CornerRadius = 8;
            this.TBPassword.IsPassword = true;
            this.TBPassword.Location = new System.Drawing.Point(112, 400);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TBPassword.PasswordChar = '•';
            this.TBPassword.Size = new System.Drawing.Size(460, 36);
            this.TBPassword.TabIndex = 14;
            // 
            // TBUsername
            // 
            this.TBUsername.BackColor = System.Drawing.Color.White;
            this.TBUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.TBUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsername.CornerRadius = 8;
            this.TBUsername.IsPassword = false;
            this.TBUsername.Location = new System.Drawing.Point(115, 336);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TBUsername.PasswordChar = '\0';
            this.TBUsername.Size = new System.Drawing.Size(460, 35);
            this.TBUsername.TabIndex = 13;
            // 
            // pnlSecureBar
            // 
            this.pnlSecureBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(59)))), ((int)(((byte)(26)))));
            this.pnlSecureBar.Controls.Add(this.label1);
            this.pnlSecureBar.Location = new System.Drawing.Point(4, 108);
            this.pnlSecureBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSecureBar.Name = "pnlSecureBar";
            this.pnlSecureBar.Size = new System.Drawing.Size(774, 28);
            this.pnlSecureBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(119)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(204, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " AUTHORISED PERSONNEL ONLY — SECURE LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(112, 453);
            this.checkBoxRemember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(291, 24);
            this.checkBoxRemember.TabIndex = 14;
            this.checkBoxRemember.Text = "Remember my username on this device";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelPassword.Location = new System.Drawing.Point(112, 382);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 20);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelUsername.Location = new System.Drawing.Point(112, 318);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 20);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(82)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.titlelbl);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.Provincelabel);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(782, 93);
            this.pnlHeader.TabIndex = 0;
            // 
            // titlelbl
            // 
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(175, 29);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(450, 30);
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "East Boom Community Health Centre";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(170)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(209, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Management System · v2.1.4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Provincelabel
            // 
            this.Provincelabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(164)))));
            this.Provincelabel.Location = new System.Drawing.Point(214, 12);
            this.Provincelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Provincelabel.Name = "Provincelabel";
            this.Provincelabel.Size = new System.Drawing.Size(360, 18);
            this.Provincelabel.TabIndex = 1;
            this.Provincelabel.Text = "KZN Province · Republic of South Africa";
            this.Provincelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your role";
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // nurseTableAdapter1
            // 
            this.nurseTableAdapter1.ClearBeforeFill = true;
            // 
            // administratorTableAdapter1
            // 
            this.administratorTableAdapter1.ClearBeforeFill = true;
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(107)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1450, 852);
            this.Controls.Add(this.roundedPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(107)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "East Boom Community Health Centre";
            this.Load += new System.EventHandler(this.Login2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.roundedPanel.ResumeLayout(false);
            this.roundedPanel.PerformLayout();
            this.panelFootBar.ResumeLayout(false);
            this.panelFootBar.PerformLayout();
            this.pnlSecureBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Provincelabel;
        private System.Windows.Forms.Panel pnlSecureBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private RoundedPanel roundedPanel;
        private System.Windows.Forms.Panel pnlHeader;
        private RoundedTextBox TBPassword;
        private RoundedTextBox TBUsername;
        private RoundedButton ButtonSignIn;
        private System.Windows.Forms.Panel panelFootBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private RoleCard roleDoctor;
        private RoleCard roleAdmin;
        private RoleCard rolePatient;
        private RoleCard roleNurse;
        private Database.DataSet1 dataSet11;
        private Database.DataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private Database.DataSet1TableAdapters.NurseTableAdapter nurseTableAdapter1;
        private Database.DataSet1TableAdapters.AdministratorTableAdapter administratorTableAdapter1;
    }
}