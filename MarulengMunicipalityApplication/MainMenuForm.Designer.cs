namespace MarulengMunicipalityApplication
{
    partial class MainMenuForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.PanelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.PanelReportIssues = new System.Windows.Forms.Panel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.PanelLocalEvents = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.PanelTrackQueries = new System.Windows.Forms.Panel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblDesc3 = new System.Windows.Forms.Label();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.lblFooterText = new System.Windows.Forms.Label();
            this.lblStrategies = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.PanelWelcome.SuspendLayout();
            this.PanelReportIssues.SuspendLayout();
            this.PanelLocalEvents.SuspendLayout();
            this.PanelTrackQueries.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Blue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(682, 110);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(150, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Maruleng Municipality";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(100, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(500, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Citizen Engagement App";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelWelcome
            // 
            this.PanelWelcome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWelcome.Controls.Add(this.lblWelcome);
            this.PanelWelcome.Location = new System.Drawing.Point(50, 130);
            this.PanelWelcome.Name = "PanelWelcome";
            this.PanelWelcome.Size = new System.Drawing.Size(600, 45);
            this.PanelWelcome.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(15, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(570, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Maruleng Citizen App";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // PanelReportIssues
            // 
            this.PanelReportIssues.BackColor = System.Drawing.Color.White;
            this.PanelReportIssues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelReportIssues.Controls.Add(this.lblTitle1);
            this.PanelReportIssues.Controls.Add(this.lblDesc1);
            this.PanelReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelReportIssues.Location = new System.Drawing.Point(150, 195);
            this.PanelReportIssues.Name = "PanelReportIssues";
            this.PanelReportIssues.Size = new System.Drawing.Size(426, 70);
            this.PanelReportIssues.TabIndex = 2;
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.Black;
            this.lblTitle1.Location = new System.Drawing.Point(20, 10);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(250, 25);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Report Issues";
            // 
            // lblDesc1
            // 
            this.lblDesc1.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDesc1.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc1.Location = new System.Drawing.Point(20, 35);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(370, 25);
            this.lblDesc1.TabIndex = 2;
            this.lblDesc1.Text = "Log service delivery problems, accidents or requests";
            // 
            // PanelLocalEvents
            // 
            this.PanelLocalEvents.BackColor = System.Drawing.Color.White;
            this.PanelLocalEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLocalEvents.Controls.Add(this.lblTitle2);
            this.PanelLocalEvents.Controls.Add(this.lblDesc2);
            this.PanelLocalEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelLocalEvents.Location = new System.Drawing.Point(150, 280);
            this.PanelLocalEvents.Name = "PanelLocalEvents";
            this.PanelLocalEvents.Size = new System.Drawing.Size(426, 70);
            this.PanelLocalEvents.TabIndex = 3;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.Black;
            this.lblTitle2.Location = new System.Drawing.Point(20, 10);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(300, 25);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Local Events & Announcements";
            // 
            // lblDesc2
            // 
            this.lblDesc2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDesc2.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc2.Location = new System.Drawing.Point(20, 35);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(387, 25);
            this.lblDesc2.TabIndex = 2;
            this.lblDesc2.Text = "View community events, meetings, and announcements";
            // 
            // PanelTrackQueries
            // 
            this.PanelTrackQueries.BackColor = System.Drawing.Color.White;
            this.PanelTrackQueries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTrackQueries.Controls.Add(this.lblTitle3);
            this.PanelTrackQueries.Controls.Add(this.lblDesc3);
            this.PanelTrackQueries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTrackQueries.Location = new System.Drawing.Point(150, 365);
            this.PanelTrackQueries.Name = "PanelTrackQueries";
            this.PanelTrackQueries.Size = new System.Drawing.Size(426, 70);
            this.PanelTrackQueries.TabIndex = 4;
            // 
            // lblTitle3
            // 
            this.lblTitle3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.Black;
            this.lblTitle3.Location = new System.Drawing.Point(20, 10);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(300, 25);
            this.lblTitle3.TabIndex = 1;
            this.lblTitle3.Text = "Track Service Requests";
            // 
            // lblDesc3
            // 
            this.lblDesc3.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDesc3.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc3.Location = new System.Drawing.Point(20, 35);
            this.lblDesc3.Name = "lblDesc3";
            this.lblDesc3.Size = new System.Drawing.Size(379, 25);
            this.lblDesc3.TabIndex = 2;
            this.lblDesc3.Text = "Check the status of your submitted reports and requests";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.Blue;
            this.PanelFooter.Controls.Add(this.lblFooterText);
            this.PanelFooter.Controls.Add(this.lblStrategies);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 478);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(682, 55);
            this.PanelFooter.TabIndex = 5;
            // 
            // lblFooterText
            // 
            this.lblFooterText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterText.ForeColor = System.Drawing.Color.White;
            this.lblFooterText.Location = new System.Drawing.Point(100, 8);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(500, 20);
            this.lblFooterText.TabIndex = 0;
            this.lblFooterText.Text = "Your Voice Matters! Together, Building a Better Maruleng";
            this.lblFooterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStrategies
            // 
            this.lblStrategies.Font = new System.Drawing.Font("Arial", 8F);
            this.lblStrategies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblStrategies.Location = new System.Drawing.Point(50, 30);
            this.lblStrategies.Name = "lblStrategies";
            this.lblStrategies.Size = new System.Drawing.Size(600, 18);
            this.lblStrategies.TabIndex = 1;
            this.lblStrategies.Text = "Engagement Strategies: WhatsApp Groups • Radio Broadcasts • Community Forums • So" +
    "cial Media • Physical Offices";
            this.lblStrategies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 533);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.PanelWelcome);
            this.Controls.Add(this.PanelReportIssues);
            this.Controls.Add(this.PanelLocalEvents);
            this.Controls.Add(this.PanelTrackQueries);
            this.Controls.Add(this.PanelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maruleng Municipality - Citizen Engagement";
            this.pnlHeader.ResumeLayout(false);
            this.PanelWelcome.ResumeLayout(false);
            this.PanelReportIssues.ResumeLayout(false);
            this.PanelLocalEvents.ResumeLayout(false);
            this.PanelTrackQueries.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Welcome Panel
        private System.Windows.Forms.Panel PanelWelcome;
        private System.Windows.Forms.Label lblWelcome;

        // Panel 1 - Report Issues (Green)
        private System.Windows.Forms.Panel PanelReportIssues;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblDesc1;

        // Panel 2 - Local Events (Orange)
        private System.Windows.Forms.Panel PanelLocalEvents;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDesc2;

        // Panel 3 - Track Queries (Blue)
        private System.Windows.Forms.Panel PanelTrackQueries;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblDesc3;

        // Footer
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Label lblFooterText;
        private System.Windows.Forms.Label lblStrategies;
    }
}