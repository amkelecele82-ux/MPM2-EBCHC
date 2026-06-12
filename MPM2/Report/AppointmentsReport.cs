using MPM2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2
{
    public partial class AppointmentsReport : Form
    {
        // 1. Removed the local declaration to fix the "Ambiguity" errors 
        // because crystalReportViewer1 is already defined in your .Designer.cs file!

        public AppointmentsReport()
        {
            InitializeComponent();
        }

        private void AppointmentsReport_Load(object sender, EventArgs e)
        {
            // Note: Remember to put your true SQL database password string here
            string connString = "Server=146.230.177.46;Database=GroupPmb6;User ID=GroupPmb6;Password=m2daz8;TrustServerCertificate=True;";
            string query = "SELECT * FROM Pro_Appointment";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataSet1 ds = new DataSet1();
                            adapter.Fill(ds, "Pro_Appointment");

                            // 2. FIX: Call your Crystal Report class layout item, NOT the Form!
                            PrescriptionReport rpt = new PrescriptionReport();
                            rpt.SetDataSource(ds);

                            // 3. FIX: Safely bind it directly to the control built on your designer canvas
                            if (this.crystalReportViewer1 != null)
                            {
                                this.crystalReportViewer1.ReportSource = rpt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}