
namespace MarulengMunicipalityApplication
{
    partial class LocalEventsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(
                "Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.label1.Location =
                new System.Drawing.Point(244, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Events And Announcements";
            this.label1.Click +=
                new System.EventHandler(this.label1_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location =
                new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search events:";

            // 
            // textBox1
            // 
            this.textBox1.Location =
                new System.Drawing.Point(148, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 2;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location =
                new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";

            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location =
                new System.Drawing.Point(148, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size =
                new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 4;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location =
                new System.Drawing.Point(28, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Event date:";

            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location =
                new System.Drawing.Point(128, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size =
                new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;

            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location =
                new System.Drawing.Point(31, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size =
                new System.Drawing.Size(106, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Filter by date";
            this.checkBox1.UseVisualStyleBackColor = true;

            // 
            // button1
            // 
            this.button1.BackColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location =
                new System.Drawing.Point(31, 293);
            this.button1.Name = "button1";
            this.button1.Size =
                new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click +=
                new System.EventHandler(this.button1_Click);

            // 
            // button2
            // 
            this.button2.Location =
                new System.Drawing.Point(28, 336);
            this.button2.Name = "button2";
            this.button2.Size =
                new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click +=
                new System.EventHandler(this.button2_Click);

            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location =
                new System.Drawing.Point(31, 381);
            this.listView1.Name = "listView1";
            this.listView1.Size =
                new System.Drawing.Size(797, 300);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View =
                System.Windows.Forms.View.Details;

            // 
            // button3
            // 
            this.button3.Location =
                new System.Drawing.Point(31, 702);
            this.button3.Name = "button3";
            this.button3.Size =
                new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back to Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click +=
                new System.EventHandler(this.button3_Click);

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.label5.Font = new System.Drawing.Font(
                "Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location =
                new System.Drawing.Point(850, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Related Community Events";

            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.ForeColor =
                System.Drawing.Color.FromArgb(0, 51, 102);
            this.listBox1.Font =
                new System.Drawing.Font("Arial", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location =
                new System.Drawing.Point(850, 410);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size =
                new System.Drawing.Size(200, 270);
            this.listBox1.TabIndex = 13;

            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize =
                new System.Drawing.Size(1070, 751);

            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            this.Name = "LocalEventsForm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text =
                "Maruleng Municipality - Local Events and Announcements";
            this.Load +=
                new System.EventHandler(this.LocalEventsForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}
