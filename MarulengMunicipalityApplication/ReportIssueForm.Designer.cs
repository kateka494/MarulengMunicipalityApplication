namespace MarulengMunicipalityApplication
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelAttachments = new System.Windows.Forms.Label();
            this.buttonAttachment = new System.Windows.Forms.Button();
            this.listBoxAttachments = new System.Windows.Forms.ListBox();
            this.buttonAttachments2 = new System.Windows.Forms.Button();
            this.progressBarReport = new System.Windows.Forms.ProgressBar();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.lblStatusCount = new System.Windows.Forms.Label();
            this.buttonSubmitReport = new System.Windows.Forms.Button();
            this.buttonBackReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(221, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Report an Issue";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(20, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 19);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location:";
            // 
            // textLocation
            // 
            this.textLocation.Font = new System.Drawing.Font("Arial", 10F);
            this.textLocation.Location = new System.Drawing.Point(120, 67);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(280, 27);
            this.textLocation.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(20, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 19);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxCategory.Location = new System.Drawing.Point(120, 107);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(280, 27);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(20, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 19);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.richTextBoxDescription.Location = new System.Drawing.Point(120, 148);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(280, 80);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.richTextBoxDescription_TextChanged);
            // 
            // labelAttachments
            // 
            this.labelAttachments.AutoSize = true;
            this.labelAttachments.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelAttachments.Location = new System.Drawing.Point(20, 250);
            this.labelAttachments.Name = "labelAttachments";
            this.labelAttachments.Size = new System.Drawing.Size(114, 19);
            this.labelAttachments.TabIndex = 7;
            this.labelAttachments.Text = "Attachments:";
            // 
            // buttonAttachment
            // 
            this.buttonAttachment.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAttachment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAttachment.Location = new System.Drawing.Point(120, 246);
            this.buttonAttachment.Name = "buttonAttachment";
            this.buttonAttachment.Size = new System.Drawing.Size(100, 28);
            this.buttonAttachment.TabIndex = 8;
            this.buttonAttachment.Text = "Add File";
            this.buttonAttachment.UseVisualStyleBackColor = false;
            this.buttonAttachment.Click += new System.EventHandler(this.buttonAttachment_Click);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.Font = new System.Drawing.Font("Arial", 9F);
            this.listBoxAttachments.ItemHeight = 17;
            this.listBoxAttachments.Location = new System.Drawing.Point(120, 280);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.Size = new System.Drawing.Size(200, 55);
            this.listBoxAttachments.TabIndex = 9;
            // 
            // buttonAttachments2
            // 
            this.buttonAttachments2.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAttachments2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAttachments2.Location = new System.Drawing.Point(325, 280);
            this.buttonAttachments2.Name = "buttonAttachments2";
            this.buttonAttachments2.Size = new System.Drawing.Size(75, 25);
            this.buttonAttachments2.TabIndex = 10;
            this.buttonAttachments2.Text = "Delete";
            this.buttonAttachments2.UseVisualStyleBackColor = false;
            this.buttonAttachments2.Click += new System.EventHandler(this.buttonAttachments2_Click);
            // 
            // progressBarReport
            // 
            this.progressBarReport.Location = new System.Drawing.Point(120, 355);
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(280, 20);
            this.progressBarReport.TabIndex = 11;
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.lblEngagement.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEngagement.Location = new System.Drawing.Point(120, 380);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(298, 20);
            this.lblEngagement.TabIndex = 12;
            this.lblEngagement.Text = "Complete the form to report your issue";
            // 
            // lblStatusCount
            // 
            this.lblStatusCount.AutoSize = true;
            this.lblStatusCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusCount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblStatusCount.Location = new System.Drawing.Point(120, 405);
            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(135, 19);
            this.lblStatusCount.TabIndex = 13;
            this.lblStatusCount.Text = "Total Reports: 0";
            // 
            // buttonSubmitReport
            // 
            this.buttonSubmitReport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSubmitReport.Enabled = false;
            this.buttonSubmitReport.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmitReport.Location = new System.Drawing.Point(120, 440);
            this.buttonSubmitReport.Name = "buttonSubmitReport";
            this.buttonSubmitReport.Size = new System.Drawing.Size(150, 35);
            this.buttonSubmitReport.TabIndex = 14;
            this.buttonSubmitReport.Text = "Submit Report";
            this.buttonSubmitReport.UseVisualStyleBackColor = false;
            this.buttonSubmitReport.Click += new System.EventHandler(this.buttonSubmitReport_Click);
            // 
            // buttonBackReport
            // 
            this.buttonBackReport.BackColor = System.Drawing.Color.LightGray;
            this.buttonBackReport.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBackReport.Location = new System.Drawing.Point(280, 440);
            this.buttonBackReport.Name = "buttonBackReport";
            this.buttonBackReport.Size = new System.Drawing.Size(120, 35);
            this.buttonBackReport.TabIndex = 15;
            this.buttonBackReport.Text = "Back to Menu";
            this.buttonBackReport.UseVisualStyleBackColor = false;
            this.buttonBackReport.Click += new System.EventHandler(this.buttonBackReport_Click);
            // 
            // ReportIssuesForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 510);
            this.Controls.Add(this.buttonBackReport);
            this.Controls.Add(this.buttonSubmitReport);
            this.Controls.Add(this.lblStatusCount);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressBarReport);
            this.Controls.Add(this.buttonAttachments2);
            this.Controls.Add(this.listBoxAttachments);
            this.Controls.Add(this.buttonAttachment);
            this.Controls.Add(this.labelAttachments);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ================================================
        // CONTROL DECLARATIONS
        // ================================================

        // Header
        private System.Windows.Forms.Label lblHeader;

        // Location
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox textLocation;

        // Category
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;

        // Description
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;

        // Attachments
        private System.Windows.Forms.Label labelAttachments;
        private System.Windows.Forms.Button buttonAttachment;
        private System.Windows.Forms.ListBox listBoxAttachments;
        private System.Windows.Forms.Button buttonAttachments2;

        // Engagement Features
        private System.Windows.Forms.ProgressBar progressBarReport;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.Label lblStatusCount;

        // Submit and Back
        private System.Windows.Forms.Button buttonSubmitReport;
        private System.Windows.Forms.Button buttonBackReport;
    }
}