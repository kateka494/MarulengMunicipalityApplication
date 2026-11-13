
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
            LoadNotifications();
        }

        // Apply the blue municipal theme

        private void ApplyFormStyle()
        {
            // Main form
            this.Text = "Maruleng Municipality - Track Service Requests";
            this.BackColor = Color.AliceBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10F);

            // Heading
            lblHeader.Text = "Track Service Requests";
            lblHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold);

            // Instructions
            labelInfor.Text =
                "View your submitted reports and their current status:";
            labelInfor.ForeColor = Color.FromArgb(0, 51, 102);
            labelInfor.Font = new Font("Arial", 10F);

            // Request list
            listViewReport.BackColor = Color.White;
            listViewReport.ForeColor = Color.FromArgb(40, 40, 40);
            listViewReport.Font = new Font("Arial", 10F);
            listViewReport.FullRowSelect = true;
            listViewReport.GridLines = true;
            listViewReport.HideSelection = false;

            // Notification heading
            lblNotifications.Text = "Request Notifications";
            lblNotifications.ForeColor = Color.FromArgb(0, 51, 102);
            lblNotifications.Font = new Font("Arial", 12F, FontStyle.Bold);

            // Notification list
            listBoxNotifications.BackColor = Color.White;
            listBoxNotifications.ForeColor = Color.FromArgb(0, 51, 102);
            listBoxNotifications.Font = new Font("Arial", 9F);

            // Back button
            buttonBackReport.Text = "Back to Menu";
            buttonBackReport.BackColor = Color.FromArgb(0, 51, 102);
            buttonBackReport.ForeColor = Color.White;
            buttonBackReport.FlatStyle = FlatStyle.Flat;
            buttonBackReport.UseVisualStyleBackColor = false;
            buttonBackReport.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonBackReport.FlatAppearance.BorderSize = 0;
            buttonBackReport.Cursor = Cursors.Hand;
        }

        // Set up the report table columns
        private void SetupReportList()
        {
            listViewReport.View = View.Details;
            listViewReport.Columns.Clear();

            listViewReport.Columns.Add("Request ID", 90);
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
                item.SubItems.Add("");

                listViewReport.Items.Add(item);
                return;
            }

            foreach (Issue issue in DataStore.Issues)
            {
                ListViewItem item = new ListViewItem(
                    issue.Id.ToString());

                item.SubItems.Add(
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


        // Display notifications for residents
        private void LoadNotifications()
        {
            listBoxNotifications.Items.Clear();

            if (DataStore.Notifications.Count == 0)
            {
                listBoxNotifications.Items.Add(
                    "You have no new notifications.");
                return;
            }

            foreach (string notification in DataStore.Notifications)
            {
                listBoxNotifications.Items.Add(notification);
            }
        }
        // Return to the main menu
        private void buttonBackReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
