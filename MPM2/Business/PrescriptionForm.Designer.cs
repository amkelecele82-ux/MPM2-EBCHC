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
            this.lblPatientNamePresc = new System.Windows.Forms.Label();
            this.lblDoctorNamePresc = new System.Windows.Forms.Label();
            this.lblDateIssuedPrescr = new System.Windows.Forms.Label();
            this.instructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new MPM2.Database.DataSet1();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.prescriptionTableAdapter = new MPM2.Database.DataSet1TableAdapters.PrescriptionTableAdapter();
            this.prescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
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
            this.instructionDataGridViewTextBoxColumn,
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.medicationNameDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn});
            this.prescriptiondataGridView1.DataSource = this.prescriptionBindingSource2;
            this.prescriptiondataGridView1.Location = new System.Drawing.Point(84, 109);
            this.prescriptiondataGridView1.Name = "prescriptiondataGridView1";
            this.prescriptiondataGridView1.Size = new System.Drawing.Size(942, 253);
            this.prescriptiondataGridView1.TabIndex = 2;
            this.prescriptiondataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptiondataGridView1_CellContentClick);
            // 
            // lblPatientNamePresc
            // 
            this.lblPatientNamePresc.AutoSize = true;
            this.lblPatientNamePresc.Location = new System.Drawing.Point(98, 401);
            this.lblPatientNamePresc.Name = "lblPatientNamePresc";
            this.lblPatientNamePresc.Size = new System.Drawing.Size(77, 13);
            this.lblPatientNamePresc.TabIndex = 3;
            this.lblPatientNamePresc.Text = "PatientName  :";
            this.lblPatientNamePresc.Click += new System.EventHandler(this.lblPatientNamePresc_Click);
            // 
            // lblDoctorNamePresc
            // 
            this.lblDoctorNamePresc.AutoSize = true;
            this.lblDoctorNamePresc.Location = new System.Drawing.Point(98, 430);
            this.lblDoctorNamePresc.Name = "lblDoctorNamePresc";
            this.lblDoctorNamePresc.Size = new System.Drawing.Size(73, 13);
            this.lblDoctorNamePresc.TabIndex = 4;
            this.lblDoctorNamePresc.Text = "Doctor Name:";
            this.lblDoctorNamePresc.Click += new System.EventHandler(this.lblDoctorNamePresc_Click);
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
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Instruction";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            // 
            // prescriptionIDDataGridViewTextBoxColumn
            // 
            this.prescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.HeaderText = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.Name = "prescriptionIDDataGridViewTextBoxColumn";
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
            this.medicationNameDataGridViewTextBoxColumn.HeaderText = "MedicationName";
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
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            // 
            // prescriptionBindingSource2
            // 
            this.prescriptionBindingSource2.DataMember = "Prescription";
            this.prescriptionBindingSource2.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
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
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1117, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateIssuedPrescr);
            this.Controls.Add(this.lblDoctorNamePresc);
            this.Controls.Add(this.lblPatientNamePresc);
            this.Controls.Add(this.prescriptiondataGridView1);
            this.Controls.Add(this.txtPrscrName);
            this.Controls.Add(this.lblPrescriptionName);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource1)).EndInit();
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
        private Database.DataSet1TableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.Label lblPatientNamePresc;
        private Database.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource prescriptionBindingSource1;
        private System.Windows.Forms.BindingSource prescriptionBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDoctorNamePresc;
        private System.Windows.Forms.Label lblDateIssuedPrescr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}