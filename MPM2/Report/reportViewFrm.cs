using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;
using System.Windows.Forms;

namespace MPM2
{
    public partial class reportViewFrm : Form
    {
        public reportViewFrm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Default: last 30 days, filter panel visible, load simple list
            dtpStart.Value = DateTime.Now.AddDays(-30).Date;
            dtpEnd.Value = DateTime.Now.Date;
            panelFilter.Visible = true;
            LoadSimpleListReport(dtpStart.Value, dtpEnd.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Reload simple list with new dates when Load button is clicked
            LoadSimpleListReport(dtpStart.Value.Date, dtpEnd.Value.Date);
        }

        // Public methods called from MainForm menu
        public void LoadAllRecords()
        {
            panelFilter.Visible = false;
            panelFilter.Height = 0;
            // Wide date range to include all appointments
            DateTime wideStart = new DateTime(1900, 1, 1);
            DateTime wideEnd = new DateTime(2100, 1, 1);
            LoadGroupedReport(wideStart, wideEnd);
        }

        public void LoadFilteredRecords()
        {
            panelFilter.Visible = true;
            LoadSimpleListReport(dtpStart.Value.Date, dtpEnd.Value.Date);
        }

        // Private methods for each report type
        private void LoadGroupedReport(DateTime startDate, DateTime endDate)
        {
            string reportPath = Path.Combine(Application.StartupPath, "rptPatientFinal.rpt");
            if (!File.Exists(reportPath))
                reportPath = Path.Combine(Application.StartupPath, "Report", "rptPatientFinal.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Grouped report not found: " + reportPath);
                return;
            }
           // MessageBox.Show("Loading grouped report: " + reportPath);
            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportPath);
            ApplyLogon(rpt);
            ApplyDateRange(rpt, startDate, endDate);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void LoadSimpleListReport(DateTime startDate, DateTime endDate)
        {
            string reportPath = Path.Combine(Application.StartupPath, "rptPatientSimpleList.rpt");
            if (!File.Exists(reportPath))
                reportPath = Path.Combine(Application.StartupPath, "Report", "rptPatientSimpleList.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Simple list report not found: " + reportPath);
                return;
            }

            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportPath);
            ApplyLogon(rpt);
            ApplyDateRange(rpt, startDate, endDate);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

       
        private void ApplyLogon(ReportDocument rpt)
        {
            TableLogOnInfo logonInfo = new TableLogOnInfo();
            logonInfo.ConnectionInfo.ServerName = "146.230.177.46";
            logonInfo.ConnectionInfo.DatabaseName = "GroupPmb6";
            logonInfo.ConnectionInfo.UserID = "GroupPmb6";
            logonInfo.ConnectionInfo.Password = "m2daz8";
            logonInfo.ConnectionInfo.IntegratedSecurity = false;
            foreach (Table table in rpt.Database.Tables)
                table.ApplyLogOnInfo(logonInfo);
        }

        private void ApplyDateRange(ReportDocument rpt, DateTime startDate, DateTime endDate)
        {
            ParameterRangeValue range = new ParameterRangeValue();
            range.StartValue = startDate;
            range.EndValue = endDate;
            range.LowerBoundType = RangeBoundType.BoundInclusive;
            range.UpperBoundType = RangeBoundType.BoundInclusive;
            rpt.SetParameterValue("DateRange", range);
        }

       
        private void viewAllToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredRecords();
        }
        public void PrintCurrentReport()
        {
            if (crystalReportViewer1.ReportSource != null)
            {
                crystalReportViewer1.PrintReport();
            }
            else
            {
                MessageBox.Show("No report loaded to print.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
    {
                if (crystalReportViewer1.ReportSource != null)
                {
                    crystalReportViewer1.PrintReport();
                }
                else
                {
                    MessageBox.Show("No report is currently loaded. Please load a report first.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
    catch (Exception ex)
    {
                MessageBox.Show("An error occurred while trying to print:\n" + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}