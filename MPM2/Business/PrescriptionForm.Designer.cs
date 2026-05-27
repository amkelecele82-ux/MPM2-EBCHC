namespace MPM2.Business
{
    partial class PrescriptionForm
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
            this.lblPrescriptionName = new System.Windows.Forms.Label();
            this.txtPrscrName = new System.Windows.Forms.TextBox();
            this.prescriptiondataGridView1 = new System.Windows.Forms.DataGridView();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new MPM2.Database.DataSet1();
            this.prescriptionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblMedicationName = new System.Windows.Forms.Label();
            this.lblDateIssuedPrescr = new System.Windows.Forms.Label();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.prescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtMedicName = new System.Windows.Forms.TextBox();
            this.txtDateIssued = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.prescriptionn_TableAdapter = new MPM2.Database.DataSet1TableAdapters.Prescriptionn_TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrescriptionName
            // 
            this.lblPrescriptionName.AutoSize = true;
            this.lblPrescriptionName.Location = new System.Drawing.Point(293, 69);
            this.lblPrescriptionName.Name = "lblPrescriptionName";
            this.lblPrescriptionName.Size = new System.Drawing.Size(133, 13);
            this.lblPrescriptionName.TabIndex = 0;
            this.lblPrescriptionName.Text = "Search Prescription Name:";
            // 
            // txtPrscrName
            // 
            this.txtPrscrName.Location = new System.Drawing.Point(461, 66);
            this.txtPrscrName.Name = "txtPrscrName";
            this.txtPrscrName.Size = new System.Drawing.Size(247, 20);
            this.txtPrscrName.TabIndex = 1;
            this.txtPrscrName.TextChanged += new System.EventHandler(this.txtPrscrName_TextChanged);
            // 
            // prescriptiondataGridView1
            // 
            this.prescriptiondataGridView1.AutoGenerateColumns = false;
            this.prescriptiondataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptiondataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.medicationNameDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.instructionDataGridViewTextBoxColumn});
            this.prescriptiondataGridView1.DataSource = this.prescriptionnBindingSource;
            this.prescriptiondataGridView1.Location = new System.Drawing.Point(84, 109);
            this.prescriptiondataGridView1.Name = "prescriptiondataGridView1";
            this.prescriptiondataGridView1.Size = new System.Drawing.Size(942, 253);
            this.prescriptiondataGridView1.TabIndex = 2;
            this.prescriptiondataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptiondataGridView1_CellContentClick);
            this.prescriptiondataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.prescriptiondataGridView1_RowHeaderMouseClick);
            // 
            // prescriptionIDDataGridViewTextBoxColumn
            // 
            this.prescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.HeaderText = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.Name = "prescriptionIDDataGridViewTextBoxColumn";
            this.prescriptionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // medicationNameDataGridViewTextBoxColumn
            // 
            this.medicationNameDataGridViewTextBoxColumn.DataPropertyName = "MedicationName";
            this.medicationNameDataGridViewTextBoxColumn.HeaderText = "Medication Name";
            this.medicationNameDataGridViewTextBoxColumn.Name = "medicationNameDataGridViewTextBoxColumn";
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            // 
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Instruction";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            // 
            // prescriptionnBindingSource
            // 
            this.prescriptionnBindingSource.DataMember = "Prescriptionn_";
            this.prescriptionnBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource2
            // 
            this.prescriptionBindingSource2.DataMember = "Prescription";
            this.prescriptionBindingSource2.DataSource = this.dataSet11;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(98, 401);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(79, 13);
            this.lblDoctorName.TabIndex = 3;
            this.lblDoctorName.Text = "Doctor Name  :";
            this.lblDoctorName.Click += new System.EventHandler(this.lblPatientNamePresc_Click);
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Location = new System.Drawing.Point(98, 430);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(93, 13);
            this.lblMedicationName.TabIndex = 4;
            this.lblMedicationName.Text = "Medication Name:";
            this.lblMedicationName.Click += new System.EventHandler(this.lblDoctorNamePresc_Click);
            // 
            // lblDateIssuedPrescr
            // 
            this.lblDateIssuedPrescr.AutoSize = true;
            this.lblDateIssuedPrescr.Location = new System.Drawing.Point(98, 464);
            this.lblDateIssuedPrescr.Name = "lblDateIssuedPrescr";
            this.lblDateIssuedPrescr.Size = new System.Drawing.Size(70, 13);
            this.lblDateIssuedPrescr.TabIndex = 5;
            this.lblDateIssuedPrescr.Text = "Date Issued :";
            this.lblDateIssuedPrescr.Click += new System.EventHandler(this.lblDateIssuedPrescr_Click);
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource1
            // 
            this.prescriptionBindingSource1.DataMember = "Prescription";
            this.prescriptionBindingSource1.DataSource = this.dataSet11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 43);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(437, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prescription Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(226, 401);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(185, 20);
            this.txtDoctorName.TabIndex = 7;
            // 
            // txtMedicName
            // 
            this.txtMedicName.Location = new System.Drawing.Point(226, 430);
            this.txtMedicName.Name = "txtMedicName";
            this.txtMedicName.ReadOnly = true;
            this.txtMedicName.Size = new System.Drawing.Size(185, 20);
            this.txtMedicName.TabIndex = 8;
            // 
            // txtDateIssued
            // 
            this.txtDateIssued.Location = new System.Drawing.Point(226, 464);
            this.txtDateIssued.Name = "txtDateIssued";
            this.txtDateIssued.ReadOnly = true;
            this.txtDateIssued.Size = new System.Drawing.Size(185, 20);
            this.txtDateIssued.TabIndex = 9;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(226, 500);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ReadOnly = true;
            this.txtInstruction.Size = new System.Drawing.Size(185, 62);
            this.txtInstruction.TabIndex = 10;
            // 
            // prescriptionn_TableAdapter
            // 
            this.prescriptionn_TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Instructions ";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1117, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.txtDateIssued);
            this.Controls.Add(this.txtMedicName);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateIssuedPrescr);
            this.Controls.Add(this.lblMedicationName);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.prescriptiondataGridView1);
            this.Controls.Add(this.txtPrscrName);
            this.Controls.Add(this.lblPrescriptionName);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource2)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrescriptionName;
        private System.Windows.Forms.TextBox txtPrscrName;
        private System.Windows.Forms.DataGridView prescriptiondataGridView1;
        private Database.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.Label lblDoctorName;
        private Database.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource prescriptionBindingSource1;
        private System.Windows.Forms.BindingSource prescriptionBindingSource2;
        private System.Windows.Forms.Label lblMedicationName;
        private System.Windows.Forms.Label lblDateIssuedPrescr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtMedicName;
        private System.Windows.Forms.TextBox txtDateIssued;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.BindingSource prescriptionnBindingSource;
        private Database.DataSet1TableAdapters.Prescriptionn_TableAdapter prescriptionn_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}