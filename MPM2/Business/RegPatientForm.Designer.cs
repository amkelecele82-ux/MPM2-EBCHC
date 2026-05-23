namespace MPM2.Business
{
    partial class RegPatientForm
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
            this.patientTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.PatientTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.TDocuments = new System.Windows.Forms.TabPage();
            this.TPDetails = new System.Windows.Forms.TabPage();
            this.TBFname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBAltPhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBEmailAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBStreetAddress = new System.Windows.Forms.TextBox();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.TPDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Patient";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TDocuments
            // 
            this.TDocuments.Location = new System.Drawing.Point(4, 25);
            this.TDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDocuments.Name = "TDocuments";
            this.TDocuments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDocuments.Size = new System.Drawing.Size(1415, 819);
            this.TDocuments.TabIndex = 4;
            this.TDocuments.Text = "Documents";
            this.TDocuments.UseVisualStyleBackColor = true;
            // 
            // TPDetails
            // 
            this.TPDetails.BackColor = System.Drawing.SystemColors.Control;
            this.TPDetails.Controls.Add(this.TBCity);
            this.TPDetails.Controls.Add(this.label13);
            this.TPDetails.Controls.Add(this.TBStreetAddress);
            this.TPDetails.Controls.Add(this.label12);
            this.TPDetails.Controls.Add(this.TBPassword);
            this.TPDetails.Controls.Add(this.label11);
            this.TPDetails.Controls.Add(this.TBUsername);
            this.TPDetails.Controls.Add(this.label7);
            this.TPDetails.Controls.Add(this.TBEmailAddress);
            this.TPDetails.Controls.Add(this.label6);
            this.TPDetails.Controls.Add(this.TBAltPhoneNo);
            this.TPDetails.Controls.Add(this.label9);
            this.TPDetails.Controls.Add(this.DTPDOB);
            this.TPDetails.Controls.Add(this.label1);
            this.TPDetails.Controls.Add(this.panel3);
            this.TPDetails.Controls.Add(this.panel2);
            this.TPDetails.Controls.Add(this.panel1);
            this.TPDetails.Controls.Add(this.TBPhoneNo);
            this.TPDetails.Controls.Add(this.textBox4);
            this.TPDetails.Controls.Add(this.TBLname);
            this.TPDetails.Controls.Add(this.textBox2);
            this.TPDetails.Controls.Add(this.TBFname);
            this.TPDetails.Controls.Add(this.label8);
            this.TPDetails.Controls.Add(this.label5);
            this.TPDetails.Controls.Add(this.label4);
            this.TPDetails.Controls.Add(this.label3);
            this.TPDetails.Controls.Add(this.label2);
            this.TPDetails.Location = new System.Drawing.Point(4, 25);
            this.TPDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDetails.Name = "TPDetails";
            this.TPDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDetails.Size = new System.Drawing.Size(1519, 819);
            this.TPDetails.TabIndex = 0;
            this.TPDetails.Text = "Personal Details";
            this.TPDetails.Click += new System.EventHandler(this.TPDetails_Click);
            // 
            // TBFname
            // 
            this.TBFname.Location = new System.Drawing.Point(573, 144);
            this.TBFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBFname.Name = "TBFname";
            this.TBFname.Size = new System.Drawing.Size(225, 22);
            this.TBFname.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1208, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1205, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Number/Passport *";
            // 
            // TBLname
            // 
            this.TBLname.Location = new System.Drawing.Point(573, 219);
            this.TBLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBLname.Name = "TBLname";
            this.TBLname.Size = new System.Drawing.Size(225, 22);
            this.TBLname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname*";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1208, 219);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name*";
            // 
            // TBPhoneNo
            // 
            this.TBPhoneNo.Location = new System.Drawing.Point(573, 300);
            this.TBPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPhoneNo.Name = "TBPhoneNo";
            this.TBPhoneNo.Size = new System.Drawing.Size(225, 22);
            this.TBPhoneNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1206, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1205, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Street Address";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-15, -23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 57);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(23, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(336, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Personal and Demographic information";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(53)))));
            this.panel2.Location = new System.Drawing.Point(-15, 789);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 44);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RegButton);
            this.panel3.Controls.Add(this.Clearbutton);
            this.panel3.Location = new System.Drawing.Point(-4, 743);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1527, 50);
            this.panel3.TabIndex = 26;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(895, 9);
            this.Clearbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(104, 31);
            this.Clearbutton.TabIndex = 27;
            this.Clearbutton.Text = "Clear Form";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(1033, 9);
            this.RegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(153, 31);
            this.RegButton.TabIndex = 28;
            this.RegButton.Text = "Register and Save";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDetails);
            this.tabControl1.Controls.Add(this.TDocuments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1527, 848);
            this.tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1206, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Folder/Patient Number";
            // 
            // DTPDOB
            // 
            this.DTPDOB.Location = new System.Drawing.Point(1208, 520);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(225, 22);
            this.DTPDOB.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Cell Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Alternative Phone Number";
            // 
            // TBAltPhoneNo
            // 
            this.TBAltPhoneNo.Location = new System.Drawing.Point(574, 383);
            this.TBAltPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBAltPhoneNo.Name = "TBAltPhoneNo";
            this.TBAltPhoneNo.Size = new System.Drawing.Size(225, 22);
            this.TBAltPhoneNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email Address";
            // 
            // TBEmailAddress
            // 
            this.TBEmailAddress.Location = new System.Drawing.Point(575, 482);
            this.TBEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBEmailAddress.Name = "TBEmailAddress";
            this.TBEmailAddress.Size = new System.Drawing.Size(225, 22);
            this.TBEmailAddress.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(569, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Username";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(573, 584);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(225, 22);
            this.TBUsername.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 651);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Password";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(576, 680);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(225, 22);
            this.TBPassword.TabIndex = 36;
            // 
            // TBStreetAddress
            // 
            this.TBStreetAddress.Location = new System.Drawing.Point(1208, 312);
            this.TBStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBStreetAddress.Name = "TBStreetAddress";
            this.TBStreetAddress.Size = new System.Drawing.Size(225, 22);
            this.TBStreetAddress.TabIndex = 38;
            // 
            // TBCity
            // 
            this.TBCity.Location = new System.Drawing.Point(1208, 415);
            this.TBCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(225, 22);
            this.TBCity.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1205, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "City";
            // 
            // RegPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 848);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegPatientForm";
            this.Text = "RegPatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.TPDetails.ResumeLayout(false);
            this.TPDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Database.DataSet1TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Database.DataSet1 dataSet1;
        private System.Windows.Forms.TabPage TDocuments;
        private System.Windows.Forms.TabPage TPDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBPhoneNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TBLname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TBFname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBEmailAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBAltPhoneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBStreetAddress;
    }
}