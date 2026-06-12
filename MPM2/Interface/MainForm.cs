using MPM2.Business;
using MPM2.Interface;
using MPM2.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2
{
    public partial class MainForm : Form
    {
        private object panelMain;

        //These are added so that we can pass the user information from the login form to other forms
        //public string CurrentUserName { get; set; }
        //public string CurrentFullName { get; set; }
        public string CurrentRole { get; set; }
        //public string CurrentPassword { get; set; }
        public DataRow CurrentDataRow { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            disableMenuItems();
            this.MainMenuStrip = menuStrip1;
            //DashboardForm1 d = new DashboardForm1();
            //LoginForm1 l = new LoginForm1();
            Login2 l = new Login2();
            formSetup(l);
        }
        public void formSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //ChildForm childForm = new ChildForm(myForm);
            //change has been done
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }
        private void disableMenuItems()
        {
            patientToolStripMenuItem.Visible = false;
            appointmentToolStripMenuItem.Visible = false;
            cToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            adminToolStripMenuItem.Visible = false;
            homeToolStripMenuItem.Visible = false;
            accountSettingsToolStripMenuItem.Visible = false;
            treatmentToolStripMenuItem.Visible = false;
        }
        public void enableMenuItems()
        {
            if (CurrentRole != null && CurrentRole.Equals("Patient"))
            {
                accountSettingsToolStripMenuItem.Visible = true;
            }
            else
            {
                accountSettingsToolStripMenuItem.Visible = true;
                homeToolStripMenuItem.Visible = true;
                patientToolStripMenuItem.Visible = true;
                appointmentToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = true;
                
                treatmentToolStripMenuItem.Visible = true;
                if (CurrentRole != null && CurrentRole.Equals("Doctor"))
                {
                    cToolStripMenuItem.Visible = true;
                }
                else
                {
                    adminToolStripMenuItem.Visible = true;
                }
            }
        }

        private void npbutton_Click(object sender, EventArgs e)
        {
            PatientForm1 p = new PatientForm1();
            formSetup(p);
        }

        private void nabutton_Click(object sender, EventArgs e)
        {
            AdminAppointment a = new AdminAppointment();
            formSetup(a);
        }

        private void tmpanel_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("test");
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatientForm1 p = new PatientForm1();
            formSetup(p);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegPatientForm2 r = new RegPatientForm2();
            formSetup(r);
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAppointment a = new AdminAppointment();
            formSetup(a);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm1 d = new DashboardForm1(CurrentRole, CurrentDataRow);
            formSetup(d);
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login2 loginForm1 = new Login2();
            disableMenuItems();
            formSetup(loginForm1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpUrl = "https://synergyseekers.netlify.app";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = helpUrl,
                    UseShellExecute = true // This forces Windows to open the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open the help page. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettingsForm a = new AccountSettingsForm(CurrentRole,CurrentDataRow);
            formSetup(a);
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegPrescriptionForm p = new RegPrescriptionForm();
            formSetup(p);

        }
       

        private void generatePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegPrescriptionForm r = new RegPrescriptionForm();  
            formSetup(r);   

        }

        private void viewAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AdminAppointment a = new AdminAppointment();
            formSetup(a);
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAppointment a = new AdminAppointment();
            a.SetTab(1);
            formSetup(a);
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentForm t = new TreatmentForm();
           formSetup(t);
        }

        private void viewAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MedicationAdministrationForm maf = new MedicationAdministrationForm();
            formSetup(maf);
        }

        private void administerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicationAdministrationForm maf = new MedicationAdministrationForm();
            maf.SetTab(1);
            formSetup(maf);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentForm t = new TreatmentForm();
            t.SetTab(1);
            formSetup(t);

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentForm t = new TreatmentForm();
            t.SetTab(1);
            formSetup(t);
        }

       

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewFrm frm = new reportViewFrm();
            formSetup(frm);
        }

        private void viewAllToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Try to find an existing report form
            reportViewFrm reportForm = null;
            foreach (Form child in this.MdiChildren)
            {
                if (child is reportViewFrm frm)
                {
                    reportForm = frm;
                    break;
                }
            }

            if (reportForm == null)
            {
                // No report form open – open one and then call LoadAllRecords
                reportForm = new reportViewFrm();
                formSetup(reportForm);
                // Use Shown event to ensure the form is fully loaded before calling
                reportForm.Shown += (s, args) => reportForm.LoadAllRecords();
            }
            else
            {
                reportForm.LoadAllRecords();
            }
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewFrm reportForm = null;
            foreach (Form child in this.MdiChildren)
            {
                if (child is reportViewFrm frm)
                {
                    reportForm = frm;
                    break;
                }
            }

            if (reportForm == null)
            {
                reportForm = new reportViewFrm();
                formSetup(reportForm);
                this.BeginInvoke(new Action(() => reportForm.LoadFilteredRecords()));
            }
            else
            {
                reportForm.LoadFilteredRecords();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  reportViewFrm reportForm = Application.OpenForms.OfType<reportViewFrm>().FirstOrDefault();
            if (reportForm != null)
            {
                reportForm.PrintCurrentReport();
            }
            else
            {
                MessageBox.Show("No report is currently open. Please open a report first.");
            }
          */
        }

        private void tempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /* AppointmentReportViewr reportViewer = new AppointmentReportViewr();
          formSetup(reportViewer);*/
         AppointmentsReport reportViewer = new AppointmentsReport();
            formSetup(reportViewer);


        }

        private void treatmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TreatmentReportViewer reportViewer = new TreatmentReportViewer();
            formSetup(reportViewer);*/
        }
    }
    }

