namespace MPM2.Business
{
    partial class MedicationAdministrationForm
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
            this.dataSet11 = new MPM2.Database.DataSet1();
            this.medicationAdministrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationAdministrationTableAdapter = new MPM2.Database.DataSet1TableAdapters.MedicationAdministrationTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.medicationAdministratorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admnisteredatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyInstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionn_TableAdapter = new MPM2.Database.DataSet1TableAdapters.Prescriptionn_TableAdapter();
            this.prescriptionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationAdministrationBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicationAdministrationBindingSource
            // 
            this.medicationAdministrationBindingSource.DataMember = "MedicationAdministration";
            this.medicationAdministrationBindingSource.DataSource = this.dataSet11;
            // 
            // medicationAdministrationTableAdapter
            // 
            this.medicationAdministrationTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1902, 1033);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1894, 1004);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1894, 1004);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1134, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 721);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administration details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 22);
            this.textBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Frequency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 341);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(588, 222);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nurse: Zanele Mkhize";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dosage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prescription: Dr. Sipho Naidoo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 756);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionIDDataGridViewTextBoxColumn1,
            this.doctorIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.medicationNameDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.instructionDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prescriptionnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 628);
            this.dataGridView1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doctor\'s Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicationAdministratorIDDataGridViewTextBoxColumn,
            this.nurseIDDataGridViewTextBoxColumn,
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.admnisteredatDataGridViewTextBoxColumn,
            this.dosageGivenDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.frequencyInstanceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.medicationAdministrationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(36, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1053, 721);
            this.dataGridView2.TabIndex = 0;
            // 
            // medicationAdministratorIDDataGridViewTextBoxColumn
            // 
            this.medicationAdministratorIDDataGridViewTextBoxColumn.DataPropertyName = "medication_AdministratorID";
            this.medicationAdministratorIDDataGridViewTextBoxColumn.HeaderText = "medication_AdministratorID";
            this.medicationAdministratorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicationAdministratorIDDataGridViewTextBoxColumn.Name = "medicationAdministratorIDDataGridViewTextBoxColumn";
            this.medicationAdministratorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicationAdministratorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nurseIDDataGridViewTextBoxColumn
            // 
            this.nurseIDDataGridViewTextBoxColumn.DataPropertyName = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.HeaderText = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nurseIDDataGridViewTextBoxColumn.Name = "nurseIDDataGridViewTextBoxColumn";
            this.nurseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // prescriptionIDDataGridViewTextBoxColumn
            // 
            this.prescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.HeaderText = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prescriptionIDDataGridViewTextBoxColumn.Name = "prescriptionIDDataGridViewTextBoxColumn";
            this.prescriptionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // admnisteredatDataGridViewTextBoxColumn
            // 
            this.admnisteredatDataGridViewTextBoxColumn.DataPropertyName = "Admnistered_at";
            this.admnisteredatDataGridViewTextBoxColumn.HeaderText = "Admnistered_at";
            this.admnisteredatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.admnisteredatDataGridViewTextBoxColumn.Name = "admnisteredatDataGridViewTextBoxColumn";
            this.admnisteredatDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosageGivenDataGridViewTextBoxColumn
            // 
            this.dosageGivenDataGridViewTextBoxColumn.DataPropertyName = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn.HeaderText = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageGivenDataGridViewTextBoxColumn.Name = "dosageGivenDataGridViewTextBoxColumn";
            this.dosageGivenDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyInstanceDataGridViewTextBoxColumn
            // 
            this.frequencyInstanceDataGridViewTextBoxColumn.DataPropertyName = "frequency_Instance";
            this.frequencyInstanceDataGridViewTextBoxColumn.HeaderText = "frequency_Instance";
            this.frequencyInstanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyInstanceDataGridViewTextBoxColumn.Name = "frequencyInstanceDataGridViewTextBoxColumn";
            this.frequencyInstanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // prescriptionnBindingSource
            // 
            this.prescriptionnBindingSource.DataMember = "Prescriptionn_";
            this.prescriptionnBindingSource.DataSource = this.dataSet11;
            // 
            // prescriptionn_TableAdapter
            // 
            this.prescriptionn_TableAdapter.ClearBeforeFill = true;
            // 
            // prescriptionIDDataGridViewTextBoxColumn1
            // 
            this.prescriptionIDDataGridViewTextBoxColumn1.DataPropertyName = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn1.HeaderText = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prescriptionIDDataGridViewTextBoxColumn1.Name = "prescriptionIDDataGridViewTextBoxColumn1";
            this.prescriptionIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prescriptionIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicationNameDataGridViewTextBoxColumn
            // 
            this.medicationNameDataGridViewTextBoxColumn.DataPropertyName = "MedicationName";
            this.medicationNameDataGridViewTextBoxColumn.HeaderText = "MedicationName";
            this.medicationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicationNameDataGridViewTextBoxColumn.Name = "medicationNameDataGridViewTextBoxColumn";
            this.medicationNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            this.dosageDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Instruction";
            this.instructionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            this.instructionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // MedicationAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tabControl1);
            this.Name = "MedicationAdministrationForm";
            this.Text = "MedicationAdministrationForm";
            this.Load += new System.EventHandler(this.MedicationAdministrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationAdministrationBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource medicationAdministrationBindingSource;
        private Database.DataSet1TableAdapters.MedicationAdministrationTableAdapter medicationAdministrationTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationAdministratorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admnisteredatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyInstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prescriptionnBindingSource;
        private Database.DataSet1TableAdapters.Prescriptionn_TableAdapter prescriptionn_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
    }
}