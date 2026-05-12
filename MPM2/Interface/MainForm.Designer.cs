namespace MPM2
{
    partial class MainForm
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
            this.tmpanel = new System.Windows.Forms.Panel();
            this.repbutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.nabutton = new System.Windows.Forms.Button();
            this.fpbutton = new System.Windows.Forms.Button();
            this.npbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmpanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmpanel
            // 
            this.tmpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.tmpanel.Controls.Add(this.panel1);
            this.tmpanel.Controls.Add(this.repbutton);
            this.tmpanel.Controls.Add(this.printbutton);
            this.tmpanel.Controls.Add(this.nabutton);
            this.tmpanel.Controls.Add(this.fpbutton);
            this.tmpanel.Controls.Add(this.npbutton);
            this.tmpanel.Location = new System.Drawing.Point(0, 0);
            this.tmpanel.Name = "tmpanel";
            this.tmpanel.Size = new System.Drawing.Size(1133, 89);
            this.tmpanel.TabIndex = 1;
            this.tmpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tmpanel_Paint);
            // 
            // repbutton
            // 
            this.repbutton.Location = new System.Drawing.Point(519, 44);
            this.repbutton.Name = "repbutton";
            this.repbutton.Size = new System.Drawing.Size(89, 27);
            this.repbutton.TabIndex = 5;
            this.repbutton.Text = "Report";
            this.repbutton.UseVisualStyleBackColor = true;
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(408, 45);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(86, 27);
            this.printbutton.TabIndex = 4;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // nabutton
            // 
            this.nabutton.Location = new System.Drawing.Point(254, 45);
            this.nabutton.Name = "nabutton";
            this.nabutton.Size = new System.Drawing.Size(130, 27);
            this.nabutton.TabIndex = 3;
            this.nabutton.Text = "New appointment";
            this.nabutton.UseVisualStyleBackColor = true;
            this.nabutton.Click += new System.EventHandler(this.nabutton_Click);
            // 
            // fpbutton
            // 
            this.fpbutton.Location = new System.Drawing.Point(131, 46);
            this.fpbutton.Name = "fpbutton";
            this.fpbutton.Size = new System.Drawing.Size(100, 27);
            this.fpbutton.TabIndex = 2;
            this.fpbutton.Text = "Find patient";
            this.fpbutton.UseVisualStyleBackColor = true;
            // 
            // npbutton
            // 
            this.npbutton.Location = new System.Drawing.Point(19, 47);
            this.npbutton.Name = "npbutton";
            this.npbutton.Size = new System.Drawing.Size(100, 27);
            this.npbutton.TabIndex = 1;
            this.npbutton.Text = "New patient";
            this.npbutton.UseVisualStyleBackColor = true;
            this.npbutton.Click += new System.EventHandler(this.npbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(53)))));
            this.panel2.Location = new System.Drawing.Point(1, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 527);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.cToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.cToolStripMenuItem.Text = "Clinical";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 32);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 597);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tmpanel);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "EAST BOOM COMMUNITY HEALTH CENTRE - PATIENT MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tmpanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tmpanel;
        private System.Windows.Forms.Button repbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button nabutton;
        private System.Windows.Forms.Button fpbutton;
        private System.Windows.Forms.Button npbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

