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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.RBDelayed = new System.Windows.Forms.RadioButton();
            this.RBMissed = new System.Windows.Forms.RadioButton();
            this.RBCompleted = new System.Windows.Forms.RadioButton();
            this.RBPending = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.TBDosageAmount = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RTBNotes = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TBPatient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBMedicine = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMedAdministration = new System.Windows.Forms.DataGridView();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyInstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medication_AdministratorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customMedAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new MPM2.Database.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPatient2 = new System.Windows.Forms.Label();
            this.TBFrequency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Recordbutton = new System.Windows.Forms.Button();
            this.RTBNotes2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBStatus2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNurse2 = new System.Windows.Forms.Label();
            this.TBDosage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoctor2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency_Instance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admnisteredatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageGivenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyInstanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicationAdministrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationAdministrationTableAdapter = new MPM2.Database.DataSet1TableAdapters.MedicationAdministrationTableAdapter();
            this.prescriptionn_TableAdapter = new MPM2.Database.DataSet1TableAdapters.Prescriptionn_TableAdapter();
            this.customMedAdmTableAdapter = new MPM2.Database.DataSet1TableAdapters.CustomMedAdmTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMedAdmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationAdministrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionnBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.ResetButton);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.RBDelayed);
            this.tabPage1.Controls.Add(this.RBMissed);
            this.tabPage1.Controls.Add(this.RBCompleted);
            this.tabPage1.Controls.Add(this.RBPending);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.TBPatient);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TBMedicine);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TBDoctor);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dgvMedAdministration);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1894, 1004);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1014, 42);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(656, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Status:";
            // 
            // RBDelayed
            // 
            this.RBDelayed.AutoSize = true;
            this.RBDelayed.Location = new System.Drawing.Point(1005, 113);
            this.RBDelayed.Name = "RBDelayed";
            this.RBDelayed.Size = new System.Drawing.Size(80, 20);
            this.RBDelayed.TabIndex = 13;
            this.RBDelayed.TabStop = true;
            this.RBDelayed.Text = "Delayed";
            this.RBDelayed.UseVisualStyleBackColor = true;
            this.RBDelayed.CheckedChanged += new System.EventHandler(this.RBDelayed_CheckedChanged);
            // 
            // RBMissed
            // 
            this.RBMissed.AutoSize = true;
            this.RBMissed.Location = new System.Drawing.Point(927, 113);
            this.RBMissed.Name = "RBMissed";
            this.RBMissed.Size = new System.Drawing.Size(72, 20);
            this.RBMissed.TabIndex = 12;
            this.RBMissed.TabStop = true;
            this.RBMissed.Text = "Missed";
            this.RBMissed.UseVisualStyleBackColor = true;
            this.RBMissed.CheckedChanged += new System.EventHandler(this.RBMissed_CheckedChanged);
            // 
            // RBCompleted
            // 
            this.RBCompleted.AutoSize = true;
            this.RBCompleted.Location = new System.Drawing.Point(826, 113);
            this.RBCompleted.Name = "RBCompleted";
            this.RBCompleted.Size = new System.Drawing.Size(94, 20);
            this.RBCompleted.TabIndex = 11;
            this.RBCompleted.TabStop = true;
            this.RBCompleted.Text = "Completed";
            this.RBCompleted.UseVisualStyleBackColor = true;
            this.RBCompleted.CheckedChanged += new System.EventHandler(this.RBCompleted_CheckedChanged);
            // 
            // RBPending
            // 
            this.RBPending.AutoSize = true;
            this.RBPending.Location = new System.Drawing.Point(740, 113);
            this.RBPending.Name = "RBPending";
            this.RBPending.Size = new System.Drawing.Size(78, 20);
            this.RBPending.TabIndex = 10;
            this.RBPending.TabStop = true;
            this.RBPending.Text = "Pending";
            this.RBPending.UseVisualStyleBackColor = true;
            this.RBPending.CheckedChanged += new System.EventHandler(this.RBPending_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Deletebutton);
            this.groupBox3.Controls.Add(this.TBDosageAmount);
            this.groupBox3.Controls.Add(this.ChangeButton);
            this.groupBox3.Controls.Add(this.CBStatus);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.RTBNotes);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(1180, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 590);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Administration Information";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(401, 544);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 15;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // TBDosageAmount
            // 
            this.TBDosageAmount.Location = new System.Drawing.Point(156, 417);
            this.TBDosageAmount.Name = "TBDosageAmount";
            this.TBDosageAmount.Size = new System.Drawing.Size(100, 22);
            this.TBDosageAmount.TabIndex = 14;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(35, 539);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 28);
            this.ChangeButton.TabIndex = 13;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(98, 461);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(158, 24);
            this.CBStatus.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Permitted Changes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 461);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Status:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 420);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Dosage Amount:";
            // 
            // RTBNotes
            // 
            this.RTBNotes.Location = new System.Drawing.Point(108, 157);
            this.RTBNotes.Name = "RTBNotes";
            this.RTBNotes.Size = new System.Drawing.Size(368, 231);
            this.RTBNotes.TabIndex = 8;
            this.RTBNotes.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Notes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Administered Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(740, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TBPatient
            // 
            this.TBPatient.Location = new System.Drawing.Point(196, 79);
            this.TBPatient.Name = "TBPatient";
            this.TBPatient.Size = new System.Drawing.Size(280, 22);
            this.TBPatient.TabIndex = 6;
            this.TBPatient.TextChanged += new System.EventHandler(this.TBPatient_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Patient:";
            // 
            // TBMedicine
            // 
            this.TBMedicine.Location = new System.Drawing.Point(196, 115);
            this.TBMedicine.Name = "TBMedicine";
            this.TBMedicine.Size = new System.Drawing.Size(280, 22);
            this.TBMedicine.TabIndex = 4;
            this.TBMedicine.TextChanged += new System.EventHandler(this.TBMedicine_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Medicine:";
            // 
            // TBDoctor
            // 
            this.TBDoctor.Location = new System.Drawing.Point(196, 36);
            this.TBDoctor.Name = "TBDoctor";
            this.TBDoctor.Size = new System.Drawing.Size(280, 22);
            this.TBDoctor.TabIndex = 2;
            this.TBDoctor.TextChanged += new System.EventHandler(this.TBDoctor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Doctor:";
            // 
            // dgvMedAdministration
            // 
            this.dgvMedAdministration.AutoGenerateColumns = false;
            this.dgvMedAdministration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorName,
            this.PatientName,
            this.MedicineName,
            this.dosageGivenDataGridViewTextBoxColumn,
            this.frequencyInstanceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.statusDataGridViewTextBoxColumn,
            this.Notes,
            this.medication_AdministratorID});
            this.dgvMedAdministration.DataSource = this.customMedAdmBindingSource;
            this.dgvMedAdministration.Location = new System.Drawing.Point(36, 172);
            this.dgvMedAdministration.Name = "dgvMedAdministration";
            this.dgvMedAdministration.RowHeadersWidth = 51;
            this.dgvMedAdministration.RowTemplate.Height = 24;
            this.dgvMedAdministration.Size = new System.Drawing.Size(1053, 460);
            this.dgvMedAdministration.TabIndex = 0;
            this.dgvMedAdministration.SelectionChanged += new System.EventHandler(this.dgvMedAdministration_SelectionChanged);
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "DoctorName";
            this.DoctorName.MinimumWidth = 6;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Width = 125;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.Width = 125;
            // 
            // MedicineName
            // 
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "MedicineName";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Width = 125;
            // 
            // dosageGivenDataGridViewTextBoxColumn
            // 
            this.dosageGivenDataGridViewTextBoxColumn.DataPropertyName = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn.HeaderText = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageGivenDataGridViewTextBoxColumn.Name = "dosageGivenDataGridViewTextBoxColumn";
            this.dosageGivenDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyInstanceDataGridViewTextBoxColumn
            // 
            this.frequencyInstanceDataGridViewTextBoxColumn.DataPropertyName = "frequency_Instance";
            this.frequencyInstanceDataGridViewTextBoxColumn.HeaderText = "Dose(#)";
            this.frequencyInstanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyInstanceDataGridViewTextBoxColumn.Name = "frequencyInstanceDataGridViewTextBoxColumn";
            this.frequencyInstanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Admnistered_at";
            this.dataGridViewTextBoxColumn4.HeaderText = "ScheduledTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // medication_AdministratorID
            // 
            this.medication_AdministratorID.DataPropertyName = "medication_AdministratorID";
            this.medication_AdministratorID.HeaderText = "medication_AdministratorID";
            this.medication_AdministratorID.MinimumWidth = 6;
            this.medication_AdministratorID.Name = "medication_AdministratorID";
            this.medication_AdministratorID.ReadOnly = true;
            this.medication_AdministratorID.Width = 125;
            // 
            // customMedAdmBindingSource
            // 
            this.customMedAdmBindingSource.DataMember = "CustomMedAdm";
            this.customMedAdmBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblPatient2);
            this.groupBox2.Controls.Add(this.TBFrequency);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Recordbutton);
            this.groupBox2.Controls.Add(this.RTBNotes2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CBStatus2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblNurse2);
            this.groupBox2.Controls.Add(this.TBDosage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblDoctor2);
            this.groupBox2.Location = new System.Drawing.Point(1034, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 681);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administration details";
            // 
            // lblPatient2
            // 
            this.lblPatient2.AutoSize = true;
            this.lblPatient2.Location = new System.Drawing.Point(31, 32);
            this.lblPatient2.Name = "lblPatient2";
            this.lblPatient2.Size = new System.Drawing.Size(119, 16);
            this.lblPatient2.TabIndex = 17;
            this.lblPatient2.Text = "Patient: John Smith";
            // 
            // TBFrequency
            // 
            this.TBFrequency.Location = new System.Drawing.Point(128, 209);
            this.TBFrequency.Name = "TBFrequency";
            this.TBFrequency.Size = new System.Drawing.Size(229, 22);
            this.TBFrequency.TabIndex = 16;
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
            // Recordbutton
            // 
            this.Recordbutton.Location = new System.Drawing.Point(311, 607);
            this.Recordbutton.Name = "Recordbutton";
            this.Recordbutton.Size = new System.Drawing.Size(75, 23);
            this.Recordbutton.TabIndex = 14;
            this.Recordbutton.Text = "Record";
            this.Recordbutton.UseVisualStyleBackColor = true;
            this.Recordbutton.Click += new System.EventHandler(this.Recordbutton_Click);
            // 
            // RTBNotes2
            // 
            this.RTBNotes2.Location = new System.Drawing.Point(34, 341);
            this.RTBNotes2.Name = "RTBNotes2";
            this.RTBNotes2.Size = new System.Drawing.Size(588, 222);
            this.RTBNotes2.TabIndex = 13;
            this.RTBNotes2.Text = "";
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
            // CBStatus2
            // 
            this.CBStatus2.FormattingEnabled = true;
            this.CBStatus2.Location = new System.Drawing.Point(128, 261);
            this.CBStatus2.Name = "CBStatus2";
            this.CBStatus2.Size = new System.Drawing.Size(229, 24);
            this.CBStatus2.TabIndex = 11;
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
            // lblNurse2
            // 
            this.lblNurse2.AutoSize = true;
            this.lblNurse2.Location = new System.Drawing.Point(31, 110);
            this.lblNurse2.Name = "lblNurse2";
            this.lblNurse2.Size = new System.Drawing.Size(136, 16);
            this.lblNurse2.TabIndex = 9;
            this.lblNurse2.Text = "Nurse: Zanele Mkhize";
            // 
            // TBDosage
            // 
            this.TBDosage.Location = new System.Drawing.Point(128, 150);
            this.TBDosage.Name = "TBDosage";
            this.TBDosage.Size = new System.Drawing.Size(229, 22);
            this.TBDosage.TabIndex = 8;
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
            // lblDoctor2
            // 
            this.lblDoctor2.AutoSize = true;
            this.lblDoctor2.Location = new System.Drawing.Point(31, 70);
            this.lblDoctor2.Name = "lblDoctor2";
            this.lblDoctor2.Size = new System.Drawing.Size(187, 16);
            this.lblDoctor2.TabIndex = 5;
            this.lblDoctor2.Text = "Prescription: Dr. Sipho Naidoo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dgvPrescription);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 681);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(550, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(417, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Date:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "Doctor Name:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(550, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(229, 22);
            this.textBox7.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Medication Name:";
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.AutoGenerateColumns = false;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.frequency_Instance,
            this.nurseNameDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.nurseIDDataGridViewTextBoxColumn,
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.admnisteredatDataGridViewTextBoxColumn,
            this.dosageGivenDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.frequencyInstanceDataGridViewTextBoxColumn1});
            this.dgvPrescription.DataSource = this.customMedAdmBindingSource;
            this.dgvPrescription.Location = new System.Drawing.Point(28, 139);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.RowHeadersWidth = 51;
            this.dgvPrescription.RowTemplate.Height = 24;
            this.dgvPrescription.Size = new System.Drawing.Size(751, 501);
            this.dgvPrescription.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DoctorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DoctorName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MedicineName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MedicineName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequency_Instance
            // 
            this.frequency_Instance.DataPropertyName = "frequency_Instance";
            this.frequency_Instance.HeaderText = "frequency_Instance";
            this.frequency_Instance.MinimumWidth = 6;
            this.frequency_Instance.Name = "frequency_Instance";
            this.frequency_Instance.Width = 125;
            // 
            // nurseNameDataGridViewTextBoxColumn
            // 
            this.nurseNameDataGridViewTextBoxColumn.DataPropertyName = "NurseName";
            this.nurseNameDataGridViewTextBoxColumn.HeaderText = "NurseName";
            this.nurseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nurseNameDataGridViewTextBoxColumn.Name = "nurseNameDataGridViewTextBoxColumn";
            this.nurseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nurseIDDataGridViewTextBoxColumn
            // 
            this.nurseIDDataGridViewTextBoxColumn.DataPropertyName = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.HeaderText = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nurseIDDataGridViewTextBoxColumn.Name = "nurseIDDataGridViewTextBoxColumn";
            this.nurseIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dosageGivenDataGridViewTextBoxColumn1
            // 
            this.dosageGivenDataGridViewTextBoxColumn1.DataPropertyName = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn1.HeaderText = "dosageGiven";
            this.dosageGivenDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dosageGivenDataGridViewTextBoxColumn1.Name = "dosageGivenDataGridViewTextBoxColumn1";
            this.dosageGivenDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // frequencyInstanceDataGridViewTextBoxColumn1
            // 
            this.frequencyInstanceDataGridViewTextBoxColumn1.DataPropertyName = "frequency_Instance";
            this.frequencyInstanceDataGridViewTextBoxColumn1.HeaderText = "frequency_Instance";
            this.frequencyInstanceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.frequencyInstanceDataGridViewTextBoxColumn1.Name = "frequencyInstanceDataGridViewTextBoxColumn1";
            this.frequencyInstanceDataGridViewTextBoxColumn1.Width = 125;
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
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Name:";
            // 
            // medicationAdministrationBindingSource
            // 
            this.medicationAdministrationBindingSource.DataMember = "MedicationAdministration";
            this.medicationAdministrationBindingSource.DataSource = this.dataSet11;
            // 
            // prescriptionnBindingSource
            // 
            this.prescriptionnBindingSource.DataMember = "Prescriptionn_";
            this.prescriptionnBindingSource.DataSource = this.dataSet11;
            // 
            // medicationAdministrationTableAdapter
            // 
            this.medicationAdministrationTableAdapter.ClearBeforeFill = true;
            // 
            // prescriptionn_TableAdapter
            // 
            this.prescriptionn_TableAdapter.ClearBeforeFill = true;
            // 
            // customMedAdmTableAdapter
            // 
            this.customMedAdmTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Scheduled Time";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(380, 148);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker3.TabIndex = 19;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMedAdmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationAdministrationBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox TBFrequency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Recordbutton;
        private System.Windows.Forms.RichTextBox RTBNotes2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBStatus2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNurse2;
        private System.Windows.Forms.TextBox TBDosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoctor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedAdministration;
        private System.Windows.Forms.BindingSource prescriptionnBindingSource;
        private Database.DataSet1TableAdapters.Prescriptionn_TableAdapter prescriptionn_TableAdapter;
        private System.Windows.Forms.TextBox TBDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBMedicine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox RTBNotes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource customMedAdmBindingSource;
        private Database.DataSet1TableAdapters.CustomMedAdmTableAdapter customMedAdmTableAdapter;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPatient2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton RBDelayed;
        private System.Windows.Forms.RadioButton RBMissed;
        private System.Windows.Forms.RadioButton RBCompleted;
        private System.Windows.Forms.RadioButton RBPending;
        private System.Windows.Forms.TextBox TBDosageAmount;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency_Instance;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admnisteredatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageGivenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyInstanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyInstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn medication_AdministratorID;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
    }
}