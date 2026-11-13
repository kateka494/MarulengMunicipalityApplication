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
            DataStore.InitialiseServiceGraph();
            ApplyMainMenuStyle();
            SetupClickablePanels();
        }

        // Apply consistent municipal styling
        private void ApplyMainMenuStyle()
        {
            this.BackColor = Color.AliceBlue;
            this.Font = new Font("Arial", 10F);

           
            Panel[] menuPanels =
            {
        PanelReportIssues,
        PanelLocalEvents,
        PanelTrackQueries
    };

            foreach (Panel panel in menuPanels)
            {
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Cursor = Cursors.Hand;
            }

            // Style the Reviewer Dashboard button
            buttonReviewer.BackColor = Color.FromArgb(0, 51, 102);
            buttonReviewer.ForeColor = Color.White;
            buttonReviewer.FlatStyle = FlatStyle.Flat;
            buttonReviewer.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonReviewer.FlatAppearance.BorderSize = 0;
            buttonReviewer.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(0, 80, 150);
            buttonReviewer.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(0, 40, 90);
            buttonReviewer.UseVisualStyleBackColor = false;
            buttonReviewer.Cursor = Cursors.Hand;
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


            
            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = Color.FromArgb(220, 235, 250);
                panel.BorderStyle = BorderStyle.Fixed3D;
            };

            panel.MouseLeave += (s, e) =>
            {
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
                    this.Hide();

                    LocalEventsForm eventsForm = new LocalEventsForm();
                    eventsForm.ShowDialog();

                    this.Show();
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

        private void buttonReviewer_Click(object sender, EventArgs e)
        {
          
            {
                ReviewerForm reviewer = new ReviewerForm();
                reviewer.ShowDialog();
            }
        }

        private void buttonDataStructures_Click(object sender, EventArgs e)
        {
            DataStructuresForm form = new DataStructuresForm();
            form.ShowDialog();
        }
    }
}