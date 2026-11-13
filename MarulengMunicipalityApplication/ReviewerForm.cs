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
    public partial class ReviewerForm : Form
    {
        public ReviewerForm()
        {
            InitializeComponent();

            ApplyReviewerStyle();
            SetupRequestList();
            LoadRequests();
        }


        // Apply consistent municipal styling
        private void ApplyReviewerStyle()
        {
            this.Text = "Maruleng Municipality - Reviewer Dashboard";
            this.BackColor = Color.AliceBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10F);

           
            Reviewlabel1.Text = "Reviewer Dashboard";
            Reviewlabel1.ForeColor = Color.FromArgb(0, 51, 102);
            Reviewlabel1.Font = new Font("Arial", 18F, FontStyle.Bold);

            
            Revielabel2.Text = "View and update submitted service requests";
            Revielabel2.ForeColor = Color.FromArgb(0, 51, 102);
            Revielabel2.Font = new Font("Arial", 10F);

           
            Reviewlabel3.Text = "Update Request Status:";
            Reviewlabel3.ForeColor = Color.FromArgb(0, 51, 102);
            Reviewlabel3.Font = new Font("Arial", 10F, FontStyle.Bold);

            
            Reviewlist.BackColor = Color.White;
            Reviewlist.ForeColor = Color.FromArgb(40, 40, 40);
            Reviewlist.Font = new Font("Arial", 10F);
            Reviewlist.FullRowSelect = true;
            Reviewlist.GridLines = true;
            Reviewlist.HideSelection = false;

           
            ReviewCombo.Items.Clear();
            ReviewCombo.Items.Add("Pending");
            ReviewCombo.Items.Add("In Progress");
            ReviewCombo.Items.Add("Resolved");
            ReviewCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ReviewCombo.SelectedIndex = 0;
            ReviewCombo.BackColor = Color.White;
            ReviewCombo.ForeColor = Color.FromArgb(0, 51, 102);
            ReviewCombo.Font = new Font("Arial", 10F);

           
            Reviewbut1.Text = "Update Status";
            Reviewbut1.BackColor = Color.FromArgb(0, 150, 136);
            Reviewbut1.ForeColor = Color.White;
            Reviewbut1.FlatStyle = FlatStyle.Flat;
            Reviewbut1.Font = new Font("Arial", 10F, FontStyle.Bold);

          
            Reviewbut2.Text = "Back to Menu";
            Reviewbut2.BackColor = Color.FromArgb(0, 51, 102);
            Reviewbut2.ForeColor = Color.White;
            Reviewbut2.FlatStyle = FlatStyle.Flat;
            Reviewbut2.Font = new Font("Arial", 10F, FontStyle.Bold);
        }



        private void SetupRequestList()
        {
            Reviewlist.View = View.Details;
            Reviewlist.Columns.Clear();

            Reviewlist.Columns.Add("Request ID", 90);
            Reviewlist.Columns.Add("Date Submitted", 150);
            Reviewlist.Columns.Add("Category", 130);
            Reviewlist.Columns.Add("Location", 180);
            Reviewlist.Columns.Add("Status", 120);
        }

       
       

            private void LoadRequests()
            {
                Reviewlist.Items.Clear();

                // Read the submitted requests
                foreach (Issue submittedIssue in DataStore.Issues)
                {
                    // Retrieve each request using the Binary Search Tree
                    Issue issue = DataStore.SearchIssueTree(submittedIssue.Id);

                    if (issue == null)
                        continue;

                    ListViewItem item = new ListViewItem(issue.Id.ToString());

                    item.SubItems.Add(
                        issue.Timestamp.ToString("dd/MM/yyyy HH:mm"));

                    item.SubItems.Add(issue.Category);
                    item.SubItems.Add(issue.Location);
                    item.SubItems.Add(issue.Status);

                    Reviewlist.Items.Add(item);
                }
            

        }

        private void ReviewerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reviewlabel3_Click(object sender, EventArgs e)
        {

        }

        private void Reviewbut1_Click(object sender, EventArgs e)
        {
            // Check whether a request has been selected
            if (Reviewlist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a service request first.");
                return;
            }

            
            int requestId = Convert.ToInt32(
                Reviewlist.SelectedItems[0].SubItems[0].Text);

            
            string newStatus = ReviewCombo.SelectedItem.ToString();

            
            DataStore.UpdateStatus(requestId, newStatus);

          
            LoadRequests();

            MessageBox.Show("Request status updated successfully!");
        }

        private void Reviewbut2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
