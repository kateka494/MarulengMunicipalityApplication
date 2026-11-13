namespace MarulengMunicipalityApplication
{
    partial class ReviewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reviewlabel1 = new System.Windows.Forms.Label();
            this.Revielabel2 = new System.Windows.Forms.Label();
            this.Reviewlist = new System.Windows.Forms.ListView();
            this.Reviewlabel3 = new System.Windows.Forms.Label();
            this.ReviewCombo = new System.Windows.Forms.ComboBox();
            this.Reviewbut1 = new System.Windows.Forms.Button();
            this.Reviewbut2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reviewlabel1
            // 
            this.Reviewlabel1.AutoSize = true;
            this.Reviewlabel1.Location = new System.Drawing.Point(288, 36);
            this.Reviewlabel1.Name = "Reviewlabel1";
            this.Reviewlabel1.Size = new System.Drawing.Size(123, 16);
            this.Reviewlabel1.TabIndex = 0;
            this.Reviewlabel1.Text = "Review Dashboard";
            this.Reviewlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Revielabel2
            // 
            this.Revielabel2.AutoSize = true;
            this.Revielabel2.Location = new System.Drawing.Point(236, 62);
            this.Revielabel2.Name = "Revielabel2";
            this.Revielabel2.Size = new System.Drawing.Size(270, 16);
            this.Revielabel2.TabIndex = 1;
            this.Revielabel2.Text = "View and update submitted service requests";
            // 
            // Reviewlist
            // 
            this.Reviewlist.HideSelection = false;
            this.Reviewlist.Location = new System.Drawing.Point(24, 100);
            this.Reviewlist.Name = "Reviewlist";
            this.Reviewlist.Size = new System.Drawing.Size(764, 156);
            this.Reviewlist.TabIndex = 2;
            this.Reviewlist.UseCompatibleStateImageBehavior = false;
            // 
            // Reviewlabel3
            // 
            this.Reviewlabel3.AutoSize = true;
            this.Reviewlabel3.Location = new System.Drawing.Point(21, 281);
            this.Reviewlabel3.Name = "Reviewlabel3";
            this.Reviewlabel3.Size = new System.Drawing.Size(149, 16);
            this.Reviewlabel3.TabIndex = 3;
            this.Reviewlabel3.Text = "Update Request Status:";
            this.Reviewlabel3.Click += new System.EventHandler(this.Reviewlabel3_Click);
            // 
            // ReviewCombo
            // 
            this.ReviewCombo.FormattingEnabled = true;
            this.ReviewCombo.Location = new System.Drawing.Point(24, 321);
            this.ReviewCombo.Name = "ReviewCombo";
            this.ReviewCombo.Size = new System.Drawing.Size(121, 24);
            this.ReviewCombo.TabIndex = 4;
            // 
            // Reviewbut1
            // 
            this.Reviewbut1.Location = new System.Drawing.Point(189, 322);
            this.Reviewbut1.Name = "Reviewbut1";
            this.Reviewbut1.Size = new System.Drawing.Size(75, 23);
            this.Reviewbut1.TabIndex = 5;
            this.Reviewbut1.Text = "button1";
            this.Reviewbut1.UseVisualStyleBackColor = true;
            this.Reviewbut1.Click += new System.EventHandler(this.Reviewbut1_Click);
            // 
            // Reviewbut2
            // 
            this.Reviewbut2.Location = new System.Drawing.Point(189, 364);
            this.Reviewbut2.Name = "Reviewbut2";
            this.Reviewbut2.Size = new System.Drawing.Size(75, 23);
            this.Reviewbut2.TabIndex = 6;
            this.Reviewbut2.Text = "button2";
            this.Reviewbut2.UseVisualStyleBackColor = true;
            this.Reviewbut2.Click += new System.EventHandler(this.Reviewbut2_Click);
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reviewbut2);
            this.Controls.Add(this.Reviewbut1);
            this.Controls.Add(this.ReviewCombo);
            this.Controls.Add(this.Reviewlabel3);
            this.Controls.Add(this.Reviewlist);
            this.Controls.Add(this.Revielabel2);
            this.Controls.Add(this.Reviewlabel1);
            this.Name = "ReviewerForm";
            this.Text = "ReviewerForm";
            this.Load += new System.EventHandler(this.ReviewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reviewlabel1;
        private System.Windows.Forms.Label Revielabel2;
        private System.Windows.Forms.ListView Reviewlist;
        private System.Windows.Forms.Label Reviewlabel3;
        private System.Windows.Forms.ComboBox ReviewCombo;
        private System.Windows.Forms.Button Reviewbut1;
        private System.Windows.Forms.Button Reviewbut2;
    }
}