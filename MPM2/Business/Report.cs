using System;
using System.Data;
using System.Windows.Forms;

namespace MPM2.Business
{
    public partial class Report : Form
    {
        // Track the date the user is currently viewing (Defaults to today's date)
        private DateTime currentReportDate = DateTime.Today;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // 1. Populate your master data tables
            pro_AppointmentTableAdapter1.Fill(dataSet11.Pro_Appointment);

            // 2. Bind your searchable dropdown list of doctors
            comboBoxDoctors.DataSource = dataSet11.Tables["FullyBookedDoctors"];
            comboBoxDoctors.DisplayMember = "DoctorName";
            comboBoxDoctors.ValueMember = "DoctorName";

            // 3. Display the initial date on screen and load the report
            UpdateDateLabel();
            LoadFilteredReport();
        }

        // Reusable method to send data to Crystal Reports based on selected Doctor and Date
        private void LoadFilteredReport()
        {
            // Create a view clone of your appointment data to apply filters locally
            DataView dv = new DataView(dataSet11.FullyBookedDoctors);

            // Filter by selected Doctor AND the specific BookingDate 
            string selectedDoctor = comboBoxDoctors.Text.Replace("'", "''"); // Prevents crash on names with apostrophes

            // Note: Ensure "BookingDate" matches your exact DataSet column name
            dv.RowFilter = string.Format("DoctorName = '{1}' AND BookingDate = #{1:yyyy-MM-dd}#",
                                         selectedDoctor, currentReportDate);

            // Bind the filtered data view to your report object
            DoctorReport cr = new DoctorReport();
            cr.SetDataSource(dv.ToTable());

            // Pass the parameter if your report still requires it
            cr.SetParameterValue("pDoctor", selectedDoctor);

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void UpdateDateLabel()
        {
            // Updates a label on your UI so the user knows what day they are looking at
            //lblSelectedDate.Text = currentReportDate.ToString("dddd, MMMM dd, yyyy");
        }

        // --- BUTTON CLICK EVENTS ---

        // Your original button1 (Load/Search Button)
     

        // "Previous Day" Button Click
       /* private void btnPrevious_Click(object sender, EventArgs e)
        {
          ;
        }
   */
        // "Next Day" Button Click
       /* private void btnNext_Click(object sender, EventArgs e)
        {
           
        }*/

        private void Load_Click(object sender, EventArgs e)
        {
            LoadFilteredReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentReportDate = currentReportDate.AddDays(1); // Add 1 day
            UpdateDateLabel();
            LoadFilteredReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentReportDate = currentReportDate.AddDays(-1); // Subtract 1 day
            UpdateDateLabel();
            LoadFilteredReport();
        }
    }
}