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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new MPM2.Database.DataSet1TableAdapters.TreatmentTableAdapter();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1373, 776);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1365, 747);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Record";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1365, 747);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.richTextBox4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1365, 747);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Treatment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(353, 192);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(353, 325);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(288, 96);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diagnosis";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(374, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Record Treatment Session";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Treatment Name";
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 524);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.dataSet1;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(466, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doctor";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(466, 144);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(288, 96);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Results";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(466, 263);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(466, 354);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(288, 24);
            this.comboBox3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Category";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(466, 478);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(288, 96);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Instruction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Requires:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(466, 613);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Doctor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(605, 611);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nurse";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Create New Treatment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 776);
            this.Controls.Add(this.tabControl1);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}