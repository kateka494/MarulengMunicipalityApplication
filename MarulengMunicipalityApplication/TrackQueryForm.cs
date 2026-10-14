
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarulengMunicipalityApplication
{
    public partial class TrackQueriesForm : Form
    {
        public TrackQueriesForm()
        {
            InitializeComponent();

            ApplyFormStyle();
            SetupReportList();
            LoadSubmittedReports();
        }

        // Apply the blue municipal theme
        private void ApplyFormStyle()
        {
            this.Text = "Maruleng Municipality - Track Service Requests";
            this.BackColor = Color.AliceBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10F);

            lblHeader.Text = "Track Service Requests";
            lblHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblHeader.Font = new Font("Arial", 16F, FontStyle.Bold);

            labelInfor.Text =
                "View your submitted reports and their current status:";
            labelInfor.ForeColor = Color.FromArgb(0, 51, 102);
            labelInfor.Font = new Font("Arial", 10F);

            listViewReport.BackColor = Color.White;
            listViewReport.ForeColor = Color.FromArgb(40, 40, 40);
            listViewReport.Font = new Font("Arial", 10F);
            listViewReport.FullRowSelect = true;
            listViewReport.GridLines = true;
            listViewReport.HideSelection = false;

            buttonBackReport.Text = "Back to Menu";
            buttonBackReport.BackColor = Color.LightGray;
            buttonBackReport.ForeColor = Color.FromArgb(0, 51, 102);
            buttonBackReport.FlatStyle = FlatStyle.Flat;
        }

        // Set up the report table columns
        private void SetupReportList()
        {
            listViewReport.View = View.Details;
            listViewReport.Columns.Clear();

            listViewReport.Columns.Add("Date Submitted", 150);
            listViewReport.Columns.Add("Category", 140);
            listViewReport.Columns.Add("Location", 200);
            listViewReport.Columns.Add("Status", 120);
        }

        // Display submitted reports
        private void LoadSubmittedReports()
        {
            listViewReport.Items.Clear();

            if (DataStore.Issues.Count == 0)
            {
                ListViewItem item =
                    new ListViewItem("No reports submitted yet.");

                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");

                listViewReport.Items.Add(item);
                return;
            }

            foreach (Issue issue in DataStore.Issues)
            {
                ListViewItem item = new ListViewItem(
                    issue.Timestamp.ToString("dd/MM/yyyy HH:mm"));

                item.SubItems.Add(issue.Category);
                item.SubItems.Add(issue.Location);
                item.SubItems.Add(issue.Status);

                if (issue.Status == "Pending")
                    item.BackColor = Color.LightYellow;
                else if (issue.Status == "In Progress")
                    item.BackColor = Color.LightBlue;
                else if (issue.Status == "Resolved")
                    item.BackColor = Color.LightGreen;

                listViewReport.Items.Add(item);
            }
        }

        // Return to the main menu
        private void buttonBackReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
