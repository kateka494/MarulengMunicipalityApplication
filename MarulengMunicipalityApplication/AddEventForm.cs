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
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();

            ApplyEventFormStyle();
            LoadEventCategories();
            LoadEventTypes();

            // Connect the buttons
            Eventbutton.Click += Eventbutton_Click;
            Eventbutton2.Click += Eventbutton2_Click;
        }

        // Apply the municipal design
        private void ApplyEventFormStyle()
        {
            this.Text = "Maruleng Municipality - Add Event";
            this.BackColor = Color.AliceBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 10F);

            // Heading and labels
            Eventlabel1.Text = "Add Community Event / Announcement";
            Eventlabel1.ForeColor = Color.FromArgb(0, 51, 102);
            Eventlabel1.Font =
                new Font("Arial", 16F, FontStyle.Bold);

            Eventlabel2.Text = "Title:";
            Eventlable3.Text = "Category:";
            Evenellabel4.Text = "Description:";
            Eventlabel5.Text = "Location:";
            Eventlabel6.Text = "Event Date:";
            Eventlabel7.Text = "Type:";

            // Title field
            Eventtext.BackColor = Color.White;
            Eventtext.Font = new Font("Arial", 10F);

            // Category dropdown
            Eventcombobox.DropDownStyle = ComboBoxStyle.DropDown;
            Eventcombobox.BackColor = Color.White;
            Eventcombobox.Font = new Font("Arial", 10F);

            // Description field
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Arial", 10F);

            // Location field
            Eventtextbox2.BackColor = Color.White;
            Eventtextbox2.Font = new Font("Arial", 10F);

            // Date picker
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Font = new Font("Arial", 10F);

            // Type dropdown
            Eventcombo2.DropDownStyle =
                ComboBoxStyle.DropDownList;
            Eventcombo2.Font = new Font("Arial", 10F);

            // Save button
            Eventbutton.Text = "Save Event";
            Eventbutton.BackColor =
                Color.FromArgb(0, 150, 136);
            Eventbutton.ForeColor = Color.White;
            Eventbutton.FlatStyle = FlatStyle.Flat;
            Eventbutton.UseVisualStyleBackColor = false;
            Eventbutton.FlatAppearance.BorderSize = 0;
            Eventbutton.Font =
                new Font("Arial", 10F, FontStyle.Bold);
            Eventbutton.Cursor = Cursors.Hand;

            // Cancel button
            Eventbutton2.Text = "Cancel";
            Eventbutton2.BackColor =
                Color.FromArgb(0, 51, 102);
            Eventbutton2.ForeColor = Color.White;
            Eventbutton2.FlatStyle = FlatStyle.Flat;
            Eventbutton2.UseVisualStyleBackColor = false;
            Eventbutton2.FlatAppearance.BorderSize = 0;
            Eventbutton2.Font =
                new Font("Arial", 10F, FontStyle.Bold);
            Eventbutton2.Cursor = Cursors.Hand;
        }

        // Load existing categories
        private void LoadEventCategories()
        {
            Eventcombobox.Items.Clear();

            foreach (string category in EventDataStore.Categories)
            {
                Eventcombobox.Items.Add(category);
            }
        }

        // Load event types
        private void LoadEventTypes()
        {
            Eventcombo2.Items.Clear();

            Eventcombo2.Items.Add("Event");
            Eventcombo2.Items.Add("Announcement");

            Eventcombo2.SelectedIndex = 0;
        }

        // Save a new event or announcement
        private void Eventbutton_Click(object sender, EventArgs e)
        {
            // Validate title
            if (string.IsNullOrWhiteSpace(Eventtext.Text))
            {
                MessageBox.Show("Please enter an event title.");
                Eventtext.Focus();
                return;
            }

            // Validate category
            if (string.IsNullOrWhiteSpace(Eventcombobox.Text))
            {
                MessageBox.Show("Please enter or select a category.");
                Eventcombobox.Focus();
                return;
            }

            // Validate description
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Please enter a description.");
                richTextBox1.Focus();
                return;
            }

            // Validate location
            if (string.IsNullOrWhiteSpace(Eventtextbox2.Text))
            {
                MessageBox.Show("Please enter a location.");
                Eventtextbox2.Focus();
                return;
            }

            // Validate event type
            if (Eventcombo2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an event type.");
                Eventcombo2.Focus();
                return;
            }

            // Create the new event
            Event newEvent = new Event(
                Eventtext.Text.Trim(),
                Eventcombobox.Text.Trim(),
                richTextBox1.Text.Trim(),
                Eventtextbox2.Text.Trim(),
                dateTimePicker1.Value.Date,
                Eventcombo2.SelectedItem.ToString()
            );

            // Assign default priority
            newEvent.Priority = 2;

            // Add the event to the existing data structures
            EventDataStore.AddEvent(newEvent);

            MessageBox.Show(
                "Event or announcement added successfully!\n\n" +
                "Event ID: " + newEvent.Id +
                "\nTitle: " + newEvent.Name +
                "\nCategory: " + newEvent.Category +
                "\nDate: " + newEvent.Date.ToString("dd MMM yyyy") +
                "\nType: " + newEvent.Type,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel button
        private void Eventbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
