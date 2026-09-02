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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            SetupClickablePanels();
        }

        private void SetupClickablePanels()
        {
            MakePanelClickable(PanelReportIssues, Color.FromArgb(0, 153, 0));
            MakePanelClickable(PanelLocalEvents, Color.FromArgb(255, 165, 0));
            MakePanelClickable(PanelTrackQueries, Color.FromArgb(0, 102, 204));
        }

        private void MakePanelClickable(Panel panel, Color color)
        {
            if (panel == null) return;

            panel.Cursor = Cursors.Hand;

            // Click events for panel and all its children
            panel.Click += (s, e) => HandlePanelClick(panel);
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += (s, e) => HandlePanelClick(panel);
            }

            // Hover effects
            panel.MouseEnter += (s, e) => {
                panel.BackColor = Color.FromArgb(245, 248, 255);
                panel.BorderStyle = BorderStyle.Fixed3D;
            };
            panel.MouseLeave += (s, e) => {
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
            };
        }

        private void HandlePanelClick(Panel panel)
        {
            try
            {
                if (panel == PanelReportIssues)
                {
                    this.Hide();
                    ReportIssuesForm reportForm = new ReportIssuesForm();
                    reportForm.ShowDialog();
                    this.Show();
                }
                else if (panel == PanelLocalEvents)
                {
                    MessageBox.Show("Local Events feature coming soon!", "Coming Soon",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (panel == PanelTrackQueries)
                {
                    this.Hide();
                    TrackQueriesForm trackForm = new TrackQueriesForm();
                    trackForm.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Keep your existing event handlers
        private void MainMenuForm_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void TrackQueries_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}