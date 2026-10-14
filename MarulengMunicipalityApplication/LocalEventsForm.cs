
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MarulengMunicipalityApplication
{
    public partial class LocalEventsForm : Form
    {
        public LocalEventsForm()
        {
            InitializeComponent();

            ApplyFormStyle();
            SetupEventList();
            LoadSampleEvents();
            LoadCategories();
            DisplayEvents();
            DisplayRecommendations();
        }

        // Apply the blue municipal theme
        private void ApplyFormStyle()
        {
            this.Text = "Maruleng Municipality - Community Noticeboard";
            this.BackColor = Color.AliceBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10F);

            label1.Text = "Local Events & Announcements";
            label1.ForeColor = Color.FromArgb(0, 51, 102);
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);

            textBox1.Font = new Font("Arial", 10F);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 10F);

            dateTimePicker1.Font = new Font("Arial", 10F);

            checkBox1.ForeColor = Color.FromArgb(0, 51, 102);

            button1.Text = "Search";
            button1.BackColor = Color.FromArgb(0, 51, 102);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;

            button2.Text = "Show All";
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(0, 51, 102);
            button2.FlatStyle = FlatStyle.Flat;

            button3.Text = "Back to Menu";
            button3.BackColor = Color.LightGray;
            button3.ForeColor = Color.FromArgb(0, 51, 102);
            button3.FlatStyle = FlatStyle.Flat;

            listView1.BackColor = Color.White;
            listView1.ForeColor = Color.FromArgb(40, 40, 40);
            listView1.Font = new Font("Arial", 10F);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;

            label5.Text = "Related Community Events";
            label5.BackColor = Color.FromArgb(0, 51, 102);
            label5.ForeColor = Color.White;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);

            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.FromArgb(0, 51, 102);
            listBox1.Font = new Font("Arial", 10F);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        // Set up the event table
        private void SetupEventList()
        {
            listView1.Columns.Clear();

            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Event / Announcement", 220);
            listView1.Columns.Add("Category", 130);
            listView1.Columns.Add("Date", 110);
            listView1.Columns.Add("Location", 170);
        }

        // Load sample community events and announcements
        private void LoadSampleEvents()
        {
            if (EventDataStore.Events.Count > 0)
                return;

            // 1. Community meeting
            EventDataStore.AddEvent(new Event(
                "Ward 5 Community Meeting - Service Delivery",
                "Community Meeting",
                "Public meeting with the Ward Councillor to discuss water supply interruptions in Hoedspruit Ext 4. Residents are encouraged to attend and raise concerns.",
                "Hoedspruit Community Hall, Maruleng",
                DateTime.Today.AddDays(7),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;

            // 2. Water supply notice
            EventDataStore.AddEvent(new Event(
                "Planned Water Interruption - Hoedspruit & Surrounds",
                "Municipal Notice",
                "DEMONSTRATION NOTICE: Example of how residents could be informed about a planned water interruption. Check official municipal announcements for confirmed dates and times.",
                "Hoedspruit, Maruleng",
                DateTime.Today.AddDays(3),
                "Announcement"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 3;

            // 3. Electricity maintenance
            EventDataStore.AddEvent(new Event(
                "Eskom Load Shedding Schedule Update",
                "Municipal Notice",
                "DEMONSTRATION NOTICE: Example of an electricity schedule announcement. Check official Eskom channels for current schedules.",
                "Maruleng Municipality",
                DateTime.Today.AddDays(2),
                "Announcement"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 3;

            // 4. Waste collection reminder
            EventDataStore.AddEvent(new Event(
                "Waste Collection Schedule - Hoedspruit",
                "Municipal Notice",
                "DEMONSTRATION NOTICE: Example reminder about refuse collection schedules. Residents should confirm collection days with the municipality.",
                "Hoedspruit Residential Areas",
                DateTime.Today.AddDays(1),
                "Announcement"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;

            // 5. Community clean-up
            EventDataStore.AddEvent(new Event(
                "Maruleng Community Clean-Up Campaign",
                "Environment",
                "DEMONSTRATION EVENT: A proposed community clean-up to promote a cleaner environment.",
                "Hoedspruit CBD & Surrounding Areas",
                DateTime.Today.AddDays(14),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 1;

            // 6. Roads and infrastructure
            EventDataStore.AddEvent(new Event(
                "R527 Road Maintenance Notice",
                "Municipal Notice",
                "DEMONSTRATION NOTICE: Example of a road maintenance announcement. Confirm roadworks and alternative routes before travelling.",
                "R527 Road, Maruleng",
                DateTime.Today.AddDays(5),
                "Announcement"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;

            // 7. IDP and budget consultation
            EventDataStore.AddEvent(new Event(
                "IDP & Budget Public Consultation - Maruleng",
                "Community Meeting",
                "DEMONSTRATION EVENT: A proposed public consultation where residents could share their views on municipal plans and budgets.",
                "Maruleng Municipal Chambers",
                DateTime.Today.AddDays(21),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;

            // 8. Health and social services
            EventDataStore.AddEvent(new Event(
                "Mobile Health Clinic - Maruleng Villages",
                "Health",
                "DEMONSTRATION EVENT: Example of a community health information notice. Confirm service availability and dates with the relevant health provider.",
                "Maruleng Rural Villages",
                DateTime.Today.AddDays(9),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;

            // 9. Community safety
            EventDataStore.AddEvent(new Event(
                "Public Safety & Crime Awareness Meeting",
                "Community Meeting",
                "DEMONSTRATION EVENT: A proposed community meeting about local safety and crime prevention.",
                "Hoedspruit SAPS Community Hall",
                DateTime.Today.AddDays(11),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 3;

            // 10. Agriculture and small business
            EventDataStore.AddEvent(new Event(
                "Small Business & Agricultural Support Workshop",
                "Economic Development",
                "DEMONSTRATION EVENT: A proposed workshop about agricultural opportunities, small business support and mentorship.",
                "Maruleng Municipality Training Centre",
                DateTime.Today.AddDays(18),
                "Event"));

            EventDataStore.Events[
                EventDataStore.Events.Count - 1].Priority = 2;
        }

        // Load unique categories into the dropdown
        private void LoadCategories()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All Categories");

            foreach (string category in EventDataStore.Categories)
            {
                comboBox1.Items.Add(category);
            }

            comboBox1.SelectedIndex = 0;
        }

        // Display upcoming events
        private void DisplayEvents()
        {
            listView1.Items.Clear();

            foreach (Event item in EventDataStore.GetUpcomingEvents())
            {
                ListViewItem row =
                    new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Name);
                row.SubItems.Add(item.Category);
                row.SubItems.Add(item.Date.ToString("dd MMM yyyy"));
                row.SubItems.Add(item.Location);

                listView1.Items.Add(row);
            }
        }

        // Recommend events related to previous searches
        private void DisplayRecommendations()
        {
            listBox1.Items.Clear();

            if (EventDataStore.SearchHistory.Count == 0)
            {
                listBox1.Items.Add(
                    "Search for an event to see suggestions.");
                return;
            }

            // Collect unique previous search terms
            HashSet<string> searches = new HashSet<string>(
                EventDataStore.SearchHistory,
                StringComparer.OrdinalIgnoreCase);

            bool found = false;

            foreach (Event item in EventDataStore.GetUpcomingEvents())
            {
                bool related = searches.Any(search =>
                    item.Name.IndexOf(
                        search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    item.Category.IndexOf(
                        search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    item.Description.IndexOf(
                        search, StringComparison.OrdinalIgnoreCase) >= 0);

                if (related)
                {
                    listBox1.Items.Add(
                        item.Name + " - " +
                        item.Date.ToString("dd MMM yyyy"));

                    found = true;
                }
            }

            if (!found)
            {
                listBox1.Items.Add(
                    "No related upcoming events found.");
            }
        }

        // Search events by text, category and optional date
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string search = textBox1.Text.Trim();

            foreach (Event item in EventDataStore.GetUpcomingEvents())
            {
                bool matchesText =
                    string.IsNullOrWhiteSpace(search) ||
                    item.Name.IndexOf(
                        search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    item.Category.IndexOf(
                        search, StringComparison.OrdinalIgnoreCase) >= 0;

                bool matchesCategory =
                    comboBox1.SelectedIndex <= 0 ||
                    item.Category.Equals(
                        comboBox1.Text,
                        StringComparison.OrdinalIgnoreCase);

                bool matchesDate =
                    !checkBox1.Checked ||
                    item.Date.Date == dateTimePicker1.Value.Date;

                if (matchesText && matchesCategory && matchesDate)
                {
                    ListViewItem row =
                        new ListViewItem(item.Id.ToString());

                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Category);
                    row.SubItems.Add(item.Date.ToString("dd MMM yyyy"));
                    row.SubItems.Add(item.Location);

                    listView1.Items.Add(row);
                }
            }

            // Save the search for future recommendations
            if (!string.IsNullOrWhiteSpace(search))
            {
                EventDataStore.AddSearch(search);
            }
            else if (comboBox1.SelectedIndex > 0)
            {
                EventDataStore.AddSearch(comboBox1.Text);
            }
            else if (checkBox1.Checked)
            {
                EventDataStore.AddSearch(
                    dateTimePicker1.Value.ToString("dd MMM yyyy"));
            }

            // Refresh recommendations after searching
            DisplayRecommendations();

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show(
                    "No matching events were found. Please try another search or date.",
                    "Search Results",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Show all upcoming events
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;

            DisplayEvents();
            DisplayRecommendations();
        }

        // Return to the main menu
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            // Events are loaded in the constructor.
        }

        // Header label click event
        private void label1_Click(object sender, EventArgs e)
        {
            // No action needed.
        }
    }
}
