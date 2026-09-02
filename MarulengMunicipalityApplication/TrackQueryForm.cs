using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarulengMunicipalityApplication
{
    public partial class TrackQueriesForm : Form
    {
        public TrackQueriesForm()
        {
            InitializeComponent();
            LoadSubmittedReports();
        }

        private void LoadSubmittedReports()
        {
            listViewReport.Items.Clear();

            if (DataStore.Issues.Count == 0)
            {
                ListViewItem item = new ListViewItem("No reports submitted yet");
                listViewReport.Items.Add(item);
                return;
            }

            foreach (Issue issue in DataStore.Issues)
            {
                ListViewItem item = new ListViewItem(issue.Timestamp.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(issue.Category);
                item.SubItems.Add(issue.Location);
                item.SubItems.Add(issue.Status);

                // Color code status
                if (issue.Status == "Pending")
                    item.BackColor = System.Drawing.Color.Orange;
                else if (issue.Status == "In Progress")
                    item.BackColor = System.Drawing.Color.LightBlue;
                else if (issue.Status == "Resolved")
                    item.BackColor = System.Drawing.Color.LightGreen;

                listViewReport.Items.Add(item);
            }
        }

        private void buttonBackReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}