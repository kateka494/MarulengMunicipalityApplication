using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarulengMunicipalityApplication
{
    public partial class ReportIssuesForm : Form
    {
        private List<string> attachedFiles = new List<string>();

        public ReportIssuesForm()
        {
            InitializeComponent();
            PopulateCategories();
            UpdateStatusCount();
            SetupProgressTracking();
        }

        private void PopulateCategories()
        {
            comboBoxCategory.Items.AddRange(new string[]
            {
                "--- Select a Category ---",
                "Water Supply",
                "Electricity",
                "Roads",
                "Waste Collection",
                "Sanitation",
                "Street Lighting",
                "Public Transport",
                "General"
            });
            comboBoxCategory.SelectedIndex = 0;
        }

        // PROGRESS TRACKING
    
        private void SetupProgressTracking()
        {
            textLocation.TextChanged += (s, e) => UpdateProgress();
            comboBoxCategory.SelectedIndexChanged += (s, e) => UpdateProgress();
            richTextBoxDescription.TextChanged += (s, e) => UpdateProgress();
        }

        private void UpdateProgress()
        {
            int progress = 0;

            // Check Location
            if (!string.IsNullOrWhiteSpace(textLocation.Text))
                progress += 25;

            // Check Category
            if (comboBoxCategory.SelectedIndex > 0)
                progress += 25;

            // Check Description
            if (!string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
                progress += 25;

            // Check Attachments
            if (attachedFiles.Count > 0)
                progress += 25;

            progressBarReport.Value = progress;

         
            if (progress == 0)
            {
                lblEngagement.Text = "Enter Location";
                lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else if (progress == 25)
            {
                lblEngagement.Text = "Select Category";
                lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else if (progress == 50)
            {
                lblEngagement.Text = "Descriobe the issue Maruleng is experiencing";
                lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else if (progress == 75)
            {
                lblEngagement.Text = "Add an attachment if available";
                lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else if (progress == 100)
            {
                lblEngagement.Text = "Click to Submit Query";
                lblEngagement.ForeColor = System.Drawing.Color.Green;
            }

            buttonSubmitReport.Enabled = (progress == 100);
        }

        private void UpdateStatusCount()
        {
            lblStatusCount.Text = $"Total Reports: {DataStore.Issues.Count}";
        }

    
        // ATTACHMENT - ADD FILE
    
        private void buttonAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select files to attach";
                    openFileDialog.Filter = "All Files|*.*|" +
                                           "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|" +
                                           "PDF Files|*.pdf|" +
                                           "Document Files|*.doc;*.docx;*.txt;*.xls;*.xlsx";
                    openFileDialog.Multiselect = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in openFileDialog.FileNames)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            if (fileInfo.Length > 10 * 1024 * 1024)
                            {
                                MessageBox.Show($"File '{Path.GetFileName(file)}' exceeds 10MB limit.",
                                               "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }

                            attachedFiles.Add(file);
                            listBoxAttachments.Items.Add($"📎 {Path.GetFileName(file)} ({fileInfo.Length / 1024}KB)");
                        }

                        MessageBox.Show($"{openFileDialog.FileNames.Length} file(s) attached successfully!",
                                       "Attachments Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateProgress();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error attaching file: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ATTACHMENT - DELETE FILE
       
        private void buttonAttachments2_Click(object sender, EventArgs e)
        {
            if (listBoxAttachments.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to remove '{listBoxAttachments.SelectedItem}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    int index = listBoxAttachments.SelectedIndex;
                    attachedFiles.RemoveAt(index);
                    listBoxAttachments.Items.RemoveAt(index);
                    UpdateProgress();

                    MessageBox.Show("File removed successfully!", "Removed",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a file to remove.", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
   
    
        private void buttonSubmitReport_Click(object sender, EventArgs e)
        {
            try
            {
                
                // ERROR HANDLING - LOCATION VALIDATION
             
                if (string.IsNullOrWhiteSpace(textLocation.Text))
                {
                    MessageBox.Show(
                        "Please enter a location.\n\n" +
                        "Hint: Enter the street name, suburb, or area where the issue is located.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    textLocation.Focus();
                    textLocation.BackColor = System.Drawing.Color.LightYellow;
                    return;
                }
                else
                {
                    textLocation.BackColor = System.Drawing.Color.White;
                }

          
                // ERROR HANDLING - CATEGORY VALIDATION
             
                if (comboBoxCategory.SelectedIndex <= 0)
                {
                    MessageBox.Show(
                        "Please select a category.\n\n" +
                        "Hint: Choose the category that best describes your issue.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    comboBoxCategory.Focus();
                    comboBoxCategory.BackColor = System.Drawing.Color.LightYellow;
                    return;
                }
                else
                {
                    comboBoxCategory.BackColor = System.Drawing.Color.White;
                }

                // ERROR HANDLING - DESCRIPTION VALIDATION
            
                if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
                {
                    MessageBox.Show(
                        "Please enter a description.\n\n" +
                        "Hint: Provide as much detail as possible so we can help you better.\n" +
                        "Include: What happened, when it started, and who is affected.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    richTextBoxDescription.Focus();
                    richTextBoxDescription.BackColor = System.Drawing.Color.LightYellow;
                    return;
                }
                else
                {
                    richTextBoxDescription.BackColor = System.Drawing.Color.White;
                }


               
                if (attachedFiles.Count == 0)
                {
                    DialogResult result = MessageBox.Show(
                        "You haven't attached any files.\n\n" +
                        "Would you like to continue without attachments?",
                        "No Attachments",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.No)
                    {
                        buttonAttachment.Focus();
                        return;
                    }
                }

                // CREATE NEW ISSUE
             
                Issue newIssue = new Issue(
                    textLocation.Text.Trim(),
                    comboBoxCategory.SelectedItem.ToString(),
                    richTextBoxDescription.Text.Trim()
                );

                // Add attachments
                foreach (string file in attachedFiles)
                {
                    newIssue.Attachments.Add(file);
                }

                // Store in DataStore
                DataStore.Issues.Add(newIssue);

             
                string attachmentInfo = attachedFiles.Count > 0 ?
                    $"\nAttachments: {attachedFiles.Count} file(s)" : "";

                MessageBox.Show(
                    "Issue submitted successfully!\n\n" +
                    $"Location: {newIssue.Location}\n" +
                    $"Category: {newIssue.Category}\n" +
                    $"Date: {newIssue.Timestamp:dd MMM yyyy HH:mm}\n" +
                    $"Status: {newIssue.Status}" +
                    attachmentInfo +
                    $"\n\nTotal reports: {DataStore.Issues.Count}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Update engagement
                lblEngagement.Text = "Thank you. Your query will be attended to!";
                lblEngagement.ForeColor = System.Drawing.Color.Green;
                UpdateStatusCount();
                ClearForm();
            }
            catch (Exception ex)
            {
                // ================================================
                // ERROR HANDLING - UNEXPECTED ERROR
                // ================================================
                MessageBox.Show(
                    "unexpected error occurred:\n\n" +
                    $"{ex.Message}\n\n" +
                    "Please try again or contact support if the problem persists.",
                    "Submission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ================================================
        // BACK BUTTON - WITH CONFIRMATION
        // ================================================
        private void buttonBackReport_Click(object sender, EventArgs e)
        {
            // Check if form has unsaved data
            if (progressBarReport.Value > 0 && progressBarReport.Value < 100)
            {
                DialogResult result = MessageBox.Show(
                    "ou have started a report but haven't submitted it.\n\n" +
                    "Are you sure you want to go back? Your progress will be lost.",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        // ================================================
        // CLEAR FORM
        // ================================================
        private void ClearForm()
        {
            textLocation.Clear();
            textLocation.BackColor = System.Drawing.Color.White;
            comboBoxCategory.SelectedIndex = 0;
            comboBoxCategory.BackColor = System.Drawing.Color.White;
            richTextBoxDescription.Clear();
            richTextBoxDescription.BackColor = System.Drawing.Color.White;
            attachedFiles.Clear();
            listBoxAttachments.Items.Clear();
            progressBarReport.Value = 0;
            lblEngagement.Text = "Complete the form to report your issue";
            lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            buttonSubmitReport.Enabled = false;
        }

        // ================================================
        // EVENT HANDLERS
        // ================================================
        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }
    }
}
