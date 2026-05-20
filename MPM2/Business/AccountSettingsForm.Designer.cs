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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.doctorTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.DoctorTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChangePassButton);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(363, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 663);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "East Boom Community Health Centre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account Info";
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Location = new System.Drawing.Point(55, 277);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(90, 34);
            this.ChangePassButton.TabIndex = 16;
            this.ChangePassButton.Text = "Change";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(52, 136);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "M2 Version | June 2026";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Synergy Seekers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Clinic Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(138, 204);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(263, 22);
            this.TBPassword.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // AccountSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Name = "AccountSettingsForm";
            this.Text = "AccountSettingsForm";
            this.Load += new System.EventHandler(this.AccountSettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label lblName;
        private Database.DataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter1;
    }
}