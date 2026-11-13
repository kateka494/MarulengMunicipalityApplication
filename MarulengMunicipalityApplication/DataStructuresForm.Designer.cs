namespace MarulengMunicipalityApplication
{
    partial class DataStructuresForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.buttonBFS = new System.Windows.Forms.Button();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.buttonMST = new System.Windows.Forms.Button();
            this.buttonTrees = new System.Windows.Forms.Button();
            this.buttonHeap = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(187, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(158, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Municipal Data Structures";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(12, 43);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(140, 16);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Select Municipal Area:";
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(12, 71);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(490, 24);
            this.comboArea.TabIndex = 2;
            // 
            // buttonBFS
            // 
            this.buttonBFS.Location = new System.Drawing.Point(30, 113);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(208, 23);
            this.buttonBFS.TabIndex = 3;
            this.buttonBFS.Text = "Run BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            // 
            // buttonDFS
            // 
            this.buttonDFS.Location = new System.Drawing.Point(284, 113);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(188, 23);
            this.buttonDFS.TabIndex = 4;
            this.buttonDFS.Text = "Run DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            // 
            // buttonMST
            // 
            this.buttonMST.Location = new System.Drawing.Point(159, 164);
            this.buttonMST.Name = "buttonMST";
            this.buttonMST.Size = new System.Drawing.Size(255, 28);
            this.buttonMST.TabIndex = 5;
            this.buttonMST.Text = "Generate Minimum Spanning Tree";
            this.buttonMST.UseVisualStyleBackColor = true;
            // 
            // buttonTrees
            // 
            this.buttonTrees.Location = new System.Drawing.Point(30, 215);
            this.buttonTrees.Name = "buttonTrees";
            this.buttonTrees.Size = new System.Drawing.Size(193, 25);
            this.buttonTrees.TabIndex = 6;
            this.buttonTrees.Text = "Demonstrate Trees";
            this.buttonTrees.UseVisualStyleBackColor = true;
            // 
            // buttonHeap
            // 
            this.buttonHeap.Location = new System.Drawing.Point(296, 215);
            this.buttonHeap.Name = "buttonHeap";
            this.buttonHeap.Size = new System.Drawing.Size(143, 25);
            this.buttonHeap.TabIndex = 7;
            this.buttonHeap.Text = "Demonstrate Priority Queue";
            this.buttonHeap.UseVisualStyleBackColor = true;
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 16;
            this.listResults.Location = new System.Drawing.Point(42, 283);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(460, 84);
            this.listResults.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(83, 410);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back to Main Menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // DataStructuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.buttonHeap);
            this.Controls.Add(this.buttonTrees);
            this.Controls.Add(this.buttonMST);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelTitle);
            this.Name = "DataStructuresForm";
            this.Text = "DataStructuresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.Button buttonDFS;
        private System.Windows.Forms.Button buttonMST;
        private System.Windows.Forms.Button buttonTrees;
        private System.Windows.Forms.Button buttonHeap;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Button buttonBack;
    }
}