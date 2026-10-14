
namespace MarulengMunicipalityApplication
{
    partial class TrackQueriesForm
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
            this.labelInfor = new System.Windows.Forms.Label();
            this.listViewReport = new System.Windows.Forms.ListView();
            this.buttonBackReport = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font(
                "Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.lblHeader.Location =
                new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size =
                new System.Drawing.Size(323, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Track Service Requests";

            // 
            // labelInfor
            // 
            this.labelInfor.AutoSize = true;
            this.labelInfor.Font =
                new System.Drawing.Font("Arial", 10F);
            this.labelInfor.ForeColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.labelInfor.Location =
                new System.Drawing.Point(20, 60);
            this.labelInfor.Name = "labelInfor";
            this.labelInfor.Size =
                new System.Drawing.Size(409, 19);
            this.labelInfor.TabIndex = 1;
            this.labelInfor.Text =
                "View your submitted reports and their current status:";

            // 
            // listViewReport
            // 
            this.listViewReport.FullRowSelect = true;
            this.listViewReport.GridLines = true;
            this.listViewReport.HideSelection = false;
            this.listViewReport.Location =
                new System.Drawing.Point(20, 90);
            this.listViewReport.Name = "listViewReport";
            this.listViewReport.Size =
                new System.Drawing.Size(640, 300);
            this.listViewReport.TabIndex = 2;
            this.listViewReport.UseCompatibleStateImageBehavior = false;
            this.listViewReport.View =
                System.Windows.Forms.View.Details;

            // 
            // buttonBackReport
            // 
            this.buttonBackReport.BackColor =
                System.Drawing.Color.LightGray;
            this.buttonBackReport.Font =
                new System.Drawing.Font(
                    "Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBackReport.Location =
                new System.Drawing.Point(265, 410);
            this.buttonBackReport.Name = "buttonBackReport";
            this.buttonBackReport.Size =
                new System.Drawing.Size(150, 35);
            this.buttonBackReport.TabIndex = 3;
            this.buttonBackReport.Text = "Back to Menu";
            this.buttonBackReport.UseVisualStyleBackColor = false;
            this.buttonBackReport.Click +=
                new System.EventHandler(
                    this.buttonBackReport_Click);

            // 
            // TrackQueriesForm
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize =
                new System.Drawing.Size(680, 470);

            this.Controls.Add(this.buttonBackReport);
            this.Controls.Add(this.listViewReport);
            this.Controls.Add(this.labelInfor);
            this.Controls.Add(this.lblHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TrackQueriesForm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text =
                "Maruleng Municipality - Track Service Requests";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label labelInfor;
        private System.Windows.Forms.ListView listViewReport;
        private System.Windows.Forms.Button buttonBackReport;
    }
}
