namespace MPM2.Business
{
    partial class AppointmentForm1
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
            this.TCAppointments = new System.Windows.Forms.TabControl();
            this.TPVA = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TPBA = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new MPM2.Database.DataSet1();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentViewTableAdapter = new MPM2.Database.DataSet1TableAdapters.AppointmentViewTableAdapter();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCAppointments.SuspendLayout();
            this.TPVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TPBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TCAppointments
            // 
            this.TCAppointments.Controls.Add(this.TPVA);
            this.TCAppointments.Controls.Add(this.TPBA);
            this.TCAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCAppointments.Location = new System.Drawing.Point(0, 0);
            this.TCAppointments.Name = "TCAppointments";
            this.TCAppointments.SelectedIndex = 0;
            this.TCAppointments.Size = new System.Drawing.Size(1186, 655);
            this.TCAppointments.TabIndex = 8;
            // 
            // TPVA
            // 
            this.TPVA.Controls.Add(this.textBox3);
            this.TPVA.Controls.Add(this.label4);
            this.TPVA.Controls.Add(this.dataGridView2);
            this.TPVA.Location = new System.Drawing.Point(4, 25);
            this.TPVA.Name = "TPVA";
            this.TPVA.Padding = new System.Windows.Forms.Padding(3);
            this.TPVA.Size = new System.Drawing.Size(1178, 626);
            this.TPVA.TabIndex = 0;
            this.TPVA.Text = "View All";
            this.TPVA.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorNameDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.appointmentStatusDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.appointmentViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(68, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1045, 469);
            this.dataGridView2.TabIndex = 0;
            // 
            // TPBA
            // 
            this.TPBA.Controls.Add(this.dataGridView1);
            this.TPBA.Controls.Add(this.textBox2);
            this.TPBA.Controls.Add(this.dateTimePicker1);
            this.TPBA.Controls.Add(this.label3);
            this.TPBA.Controls.Add(this.textBox1);
            this.TPBA.Controls.Add(this.button1);
            this.TPBA.Controls.Add(this.label2);
            this.TPBA.Controls.Add(this.label1);
            this.TPBA.Location = new System.Drawing.Point(4, 25);
            this.TPBA.Name = "TPBA";
            this.TPBA.Padding = new System.Windows.Forms.Padding(3);
            this.TPBA.Size = new System.Drawing.Size(1178, 626);
            this.TPBA.TabIndex = 1;
            this.TPBA.Text = "Book";
            this.TPBA.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doctor Name:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataMember = "AppointmentView";
            this.appointmentViewBindingSource.DataSource = this.dataSet1;
            // 
            // appointmentViewTableAdapter
            // 
            this.appointmentViewTableAdapter.ClearBeforeFill = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentStatusDataGridViewTextBoxColumn
            // 
            this.appointmentStatusDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Status";
            this.appointmentStatusDataGridViewTextBoxColumn.HeaderText = "Appointment_Status";
            this.appointmentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentStatusDataGridViewTextBoxColumn.Name = "appointmentStatusDataGridViewTextBoxColumn";
            this.appointmentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            this.appointmentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // AppointmentForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 655);
            this.Controls.Add(this.TCAppointments);
            this.Name = "AppointmentForm1";
            this.Text = "AppointmentForm1";
            this.Load += new System.EventHandler(this.AppointmentForm1_Load);
            this.TCAppointments.ResumeLayout(false);
            this.TPVA.ResumeLayout(false);
            this.TPVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TPBA.ResumeLayout(false);
            this.TPBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAppointments;
        private System.Windows.Forms.TabPage TPVA;
        private System.Windows.Forms.TabPage TPBA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private Database.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private Database.DataSet1TableAdapters.AppointmentViewTableAdapter appointmentViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
    }
}