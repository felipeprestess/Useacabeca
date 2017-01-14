namespace DesculpasDeBrian
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.FileDate = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File date";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(35, 149);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(90, 24);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(131, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(225, 149);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 24);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(319, 149);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(88, 24);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(73, 12);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(334, 20);
            this.description.TabIndex = 8;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(73, 41);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(334, 20);
            this.results.TabIndex = 9;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // FileDate
            // 
            this.FileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileDate.Location = new System.Drawing.Point(73, 98);
            this.FileDate.Name = "FileDate";
            this.FileDate.Size = new System.Drawing.Size(334, 20);
            this.FileDate.TabIndex = 11;
            this.FileDate.Text = "label5";
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(73, 73);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(334, 20);
            this.lastUsed.TabIndex = 12;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save As";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 185);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.FileDate);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label FileDate;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

