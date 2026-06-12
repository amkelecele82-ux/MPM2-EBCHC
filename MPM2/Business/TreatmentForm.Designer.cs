namespace MPM2.Business
{
    partial class TreatmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbTreatment = new System.Windows.Forms.ComboBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.rtbDiagnosis = new System.Windows.Forms.RichTextBox();
            this.btRecord = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRecord = new System.Windows.Forms.TabPage();
            this.tpView = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treatmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiresDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiresNurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.txtTreatName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.bttnCreate = new System.Windows.Forms.Button();
            this.rbNurse = new System.Windows.Forms.RadioButton();
            this.rbDoctor = new System.Windows.Forms.RadioButton();
            this.rtbInstruction = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.treatmentTableAdapter = new MPM2.Database.DataSet1TableAdapters.TreatmentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpRecord.SuspendLayout();
            this.tpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Treatment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagnosis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 4;
            // 
            // cbTreatment
            // 
            this.cbTreatment.FormattingEnabled = true;
            this.cbTreatment.Location = new System.Drawing.Point(302, 110);
            this.cbTreatment.Name = "cbTreatment";
            this.cbTreatment.Size = new System.Drawing.Size(249, 24);
            this.cbTreatment.TabIndex = 5;
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(302, 193);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(249, 104);
            this.rtbResults.TabIndex = 6;
            this.rtbResults.Text = "";
            // 
            // rtbDiagnosis
            // 
            this.rtbDiagnosis.Location = new System.Drawing.Point(302, 339);
            this.rtbDiagnosis.Name = "rtbDiagnosis";
            this.rtbDiagnosis.Size = new System.Drawing.Size(249, 96);
            this.rtbDiagnosis.TabIndex = 7;
            this.rtbDiagnosis.Text = "";
            // 
            // btRecord
            // 
            this.btRecord.Location = new System.Drawing.Point(302, 498);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(249, 23);
            this.btRecord.TabIndex = 8;
            this.btRecord.Text = "Record Treatment Session";
            this.btRecord.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRecord);
            this.tabControl1.Controls.Add(this.tpView);
            this.tabControl1.Controls.Add(this.tpCreate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1469, 700);
            this.tabControl1.TabIndex = 9;
            // 
            // tpRecord
            // 
            this.tpRecord.Controls.Add(this.button1);
            this.tpRecord.Controls.Add(this.textBox1);
            this.tpRecord.Controls.Add(this.label4);
            this.tpRecord.Controls.Add(this.btRecord);
            this.tpRecord.Controls.Add(this.label3);
            this.tpRecord.Controls.Add(this.cbTreatment);
            this.tpRecord.Controls.Add(this.label2);
            this.tpRecord.Controls.Add(this.rtbDiagnosis);
            this.tpRecord.Controls.Add(this.label1);
            this.tpRecord.Controls.Add(this.rtbResults);
            this.tpRecord.Location = new System.Drawing.Point(4, 25);
            this.tpRecord.Name = "tpRecord";
            this.tpRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecord.Size = new System.Drawing.Size(1461, 671);
            this.tpRecord.TabIndex = 0;
            this.tpRecord.Text = "Record";
            this.tpRecord.UseVisualStyleBackColor = true;
            // 
            // tpView
            // 
            this.tpView.Controls.Add(this.dataGridView1);
            this.tpView.Controls.Add(this.txtTreatName);
            this.tpView.Controls.Add(this.label5);
            this.tpView.Location = new System.Drawing.Point(4, 25);
            this.tpView.Name = "tpView";
            this.tpView.Padding = new System.Windows.Forms.Padding(3);
            this.tpView.Size = new System.Drawing.Size(1461, 671);
            this.tpView.TabIndex = 1;
            this.tpView.Text = "View";
            this.tpView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatmentIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.nurseIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.instructionsDataGridViewTextBoxColumn,
            this.requiresDoctorDataGridViewTextBoxColumn,
            this.requiresNurseDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.treatmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 356);
            this.dataGridView1.TabIndex = 2;
            // 
            // treatmentIDDataGridViewTextBoxColumn
            // 
            this.treatmentIDDataGridViewTextBoxColumn.DataPropertyName = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.HeaderText = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treatmentIDDataGridViewTextBoxColumn.Name = "treatmentIDDataGridViewTextBoxColumn";
            this.treatmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.treatmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nurseIDDataGridViewTextBoxColumn
            // 
            this.nurseIDDataGridViewTextBoxColumn.DataPropertyName = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.HeaderText = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nurseIDDataGridViewTextBoxColumn.Name = "nurseIDDataGridViewTextBoxColumn";
            this.nurseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            this.instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.HeaderText = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            this.instructionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // requiresDoctorDataGridViewTextBoxColumn
            // 
            this.requiresDoctorDataGridViewTextBoxColumn.DataPropertyName = "RequiresDoctor";
            this.requiresDoctorDataGridViewTextBoxColumn.HeaderText = "RequiresDoctor";
            this.requiresDoctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiresDoctorDataGridViewTextBoxColumn.Name = "requiresDoctorDataGridViewTextBoxColumn";
            this.requiresDoctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // requiresNurseDataGridViewTextBoxColumn
            // 
            this.requiresNurseDataGridViewTextBoxColumn.DataPropertyName = "RequiresNurse";
            this.requiresNurseDataGridViewTextBoxColumn.HeaderText = "RequiresNurse";
            this.requiresNurseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiresNurseDataGridViewTextBoxColumn.Name = "requiresNurseDataGridViewTextBoxColumn";
            this.requiresNurseDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTreatName
            // 
            this.txtTreatName.Location = new System.Drawing.Point(398, 51);
            this.txtTreatName.Name = "txtTreatName";
            this.txtTreatName.Size = new System.Drawing.Size(184, 22);
            this.txtTreatName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Treatment Name";
            // 
            // tpCreate
            // 
            this.tpCreate.Controls.Add(this.bttnCreate);
            this.tpCreate.Controls.Add(this.rbNurse);
            this.tpCreate.Controls.Add(this.rbDoctor);
            this.tpCreate.Controls.Add(this.rtbInstruction);
            this.tpCreate.Controls.Add(this.richTextBox1);
            this.tpCreate.Controls.Add(this.cbDoctor);
            this.tpCreate.Controls.Add(this.cbCategory);
            this.tpCreate.Controls.Add(this.txtbName);
            this.tpCreate.Controls.Add(this.label11);
            this.tpCreate.Controls.Add(this.label10);
            this.tpCreate.Controls.Add(this.label9);
            this.tpCreate.Controls.Add(this.label8);
            this.tpCreate.Controls.Add(this.label7);
            this.tpCreate.Controls.Add(this.label6);
            this.tpCreate.Location = new System.Drawing.Point(4, 25);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreate.Size = new System.Drawing.Size(1461, 671);
            this.tpCreate.TabIndex = 2;
            this.tpCreate.Text = "Create";
            this.tpCreate.UseVisualStyleBackColor = true;
            this.tpCreate.Click += new System.EventHandler(this.tpCreate_Click);
            // 
            // bttnCreate
            // 
            this.bttnCreate.Location = new System.Drawing.Point(283, 617);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(220, 23);
            this.bttnCreate.TabIndex = 13;
            this.bttnCreate.Text = "Create New Treatment";
            this.bttnCreate.UseVisualStyleBackColor = true;
            // 
            // rbNurse
            // 
            this.rbNurse.AutoSize = true;
            this.rbNurse.Location = new System.Drawing.Point(439, 552);
            this.rbNurse.Name = "rbNurse";
            this.rbNurse.Size = new System.Drawing.Size(64, 20);
            this.rbNurse.TabIndex = 12;
            this.rbNurse.TabStop = true;
            this.rbNurse.Text = "Nurse";
            this.rbNurse.UseVisualStyleBackColor = true;
            // 
            // rbDoctor
            // 
            this.rbDoctor.AutoSize = true;
            this.rbDoctor.Location = new System.Drawing.Point(283, 552);
            this.rbDoctor.Name = "rbDoctor";
            this.rbDoctor.Size = new System.Drawing.Size(68, 20);
            this.rbDoctor.TabIndex = 11;
            this.rbDoctor.TabStop = true;
            this.rbDoctor.Text = "Doctor";
            this.rbDoctor.UseVisualStyleBackColor = true;
            // 
            // rtbInstruction
            // 
            this.rtbInstruction.Location = new System.Drawing.Point(283, 392);
            this.rtbInstruction.Name = "rtbInstruction";
            this.rtbInstruction.Size = new System.Drawing.Size(220, 96);
            this.rtbInstruction.TabIndex = 10;
            this.rtbInstruction.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(283, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(283, 257);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(220, 24);
            this.cbDoctor.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(283, 315);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(220, 24);
            this.cbCategory.TabIndex = 7;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(283, 37);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(220, 22);
            this.txtbName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 552);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Requires:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Instruction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRecord.ResumeLayout(false);
            this.tpRecord.PerformLayout();
            this.tpView.ResumeLayout(false);
            this.tpView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tpCreate.ResumeLayout(false);
            this.tpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbTreatment;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.RichTextBox rtbDiagnosis;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRecord;
        private System.Windows.Forms.TabPage tpView;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTreatName;
        private System.Windows.Forms.Label label5;
        private Database.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private Database.DataSet1TableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiresDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiresNurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bttnCreate;
        private System.Windows.Forms.RadioButton rbNurse;
        private System.Windows.Forms.RadioButton rbDoctor;
        private System.Windows.Forms.RichTextBox rtbInstruction;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}