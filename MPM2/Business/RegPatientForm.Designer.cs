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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPDetails = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TMedHistory = new System.Windows.Forms.TabPage();
            this.TCConditions = new System.Windows.Forms.TabPage();
            this.TNKin = new System.Windows.Forms.TabPage();
            this.TDocuments = new System.Windows.Forms.TabPage();
            this.patientTableAdapter1 = new MPM2.Database.DataSet1TableAdapters.PatientTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.tabControl1.SuspendLayout();
            this.TPDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDetails);
            this.tabControl1.Controls.Add(this.TMedHistory);
            this.tabControl1.Controls.Add(this.TCConditions);
            this.tabControl1.Controls.Add(this.TNKin);
            this.tabControl1.Controls.Add(this.TDocuments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 689);
            this.tabControl1.TabIndex = 0;
            // 
            // TPDetails
            // 
            this.TPDetails.BackColor = System.Drawing.SystemColors.Control;
            this.TPDetails.Controls.Add(this.panel3);
            this.TPDetails.Controls.Add(this.panel2);
            this.TPDetails.Controls.Add(this.panel1);
            this.TPDetails.Controls.Add(this.label9);
            this.TPDetails.Controls.Add(this.textBox9);
            this.TPDetails.Controls.Add(this.label8);
            this.TPDetails.Controls.Add(this.textBox8);
            this.TPDetails.Controls.Add(this.label7);
            this.TPDetails.Controls.Add(this.textBox7);
            this.TPDetails.Controls.Add(this.label6);
            this.TPDetails.Controls.Add(this.textBox6);
            this.TPDetails.Controls.Add(this.label5);
            this.TPDetails.Controls.Add(this.textBox5);
            this.TPDetails.Controls.Add(this.label4);
            this.TPDetails.Controls.Add(this.textBox4);
            this.TPDetails.Controls.Add(this.label3);
            this.TPDetails.Controls.Add(this.textBox3);
            this.TPDetails.Controls.Add(this.label2);
            this.TPDetails.Controls.Add(this.textBox2);
            this.TPDetails.Controls.Add(this.label1);
            this.TPDetails.Controls.Add(this.textBox1);
            this.TPDetails.Location = new System.Drawing.Point(4, 22);
            this.TPDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TPDetails.Name = "TPDetails";
            this.TPDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TPDetails.Size = new System.Drawing.Size(1059, 663);
            this.TPDetails.TabIndex = 0;
            this.TPDetails.Text = "Personal Details";
            this.TPDetails.Click += new System.EventHandler(this.TPDetails_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(-3, 604);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 41);
            this.panel3.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "Register and Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear Form";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save Draft";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(53)))));
            this.panel2.Location = new System.Drawing.Point(-11, 641);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 36);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-11, -19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 46);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(17, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Personal and Demographic information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 367);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cell Phone Number";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(699, 391);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(170, 20);
            this.textBox9.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Residential Address";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(223, 330);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(197, 96);
            this.textBox8.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Folder/Patient Number";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(700, 330);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(170, 20);
            this.textBox7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender*";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(700, 244);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth*";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 244);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name*";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(699, 178);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname*";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 178);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Number/Passport *";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(699, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder/Patient Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // TMedHistory
            // 
            this.TMedHistory.Location = new System.Drawing.Point(4, 22);
            this.TMedHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TMedHistory.Name = "TMedHistory";
            this.TMedHistory.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TMedHistory.Size = new System.Drawing.Size(1059, 663);
            this.TMedHistory.TabIndex = 1;
            this.TMedHistory.Text = "Medical History";
            this.TMedHistory.UseVisualStyleBackColor = true;
            // 
            // TCConditions
            // 
            this.TCConditions.Location = new System.Drawing.Point(4, 22);
            this.TCConditions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TCConditions.Name = "TCConditions";
            this.TCConditions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TCConditions.Size = new System.Drawing.Size(1059, 663);
            this.TCConditions.TabIndex = 2;
            this.TCConditions.Text = "Chronic Conditions";
            this.TCConditions.UseVisualStyleBackColor = true;
            // 
            // TNKin
            // 
            this.TNKin.Location = new System.Drawing.Point(4, 22);
            this.TNKin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TNKin.Name = "TNKin";
            this.TNKin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TNKin.Size = new System.Drawing.Size(1059, 663);
            this.TNKin.TabIndex = 3;
            this.TNKin.Text = "Next of Kin";
            this.TNKin.UseVisualStyleBackColor = true;
            // 
            // TDocuments
            // 
            this.TDocuments.Location = new System.Drawing.Point(4, 22);
            this.TDocuments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TDocuments.Name = "TDocuments";
            this.TDocuments.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TDocuments.Size = new System.Drawing.Size(1059, 663);
            this.TDocuments.TabIndex = 4;
            this.TDocuments.Text = "Documents";
            this.TDocuments.UseVisualStyleBackColor = true;
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
            // RegPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 689);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegPatientForm";
            this.Text = "RegPatientForm";
            this.tabControl1.ResumeLayout(false);
            this.TPDetails.ResumeLayout(false);
            this.TPDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPDetails;
        private System.Windows.Forms.TabPage TMedHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TCConditions;
        private System.Windows.Forms.TabPage TNKin;
        private System.Windows.Forms.TabPage TDocuments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Database.DataSet1TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Database.DataSet1 dataSet1;
    }
}