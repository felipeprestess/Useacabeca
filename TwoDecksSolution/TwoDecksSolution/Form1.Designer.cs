namespace TwoDecksSolution
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
            this.btnMoveToDeck2 = new System.Windows.Forms.Button();
            this.btnMoveToDeck1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnShuffle1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnShuffle2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoveToDeck2
            // 
            this.btnMoveToDeck2.Location = new System.Drawing.Point(158, 114);
            this.btnMoveToDeck2.Name = "btnMoveToDeck2";
            this.btnMoveToDeck2.Size = new System.Drawing.Size(38, 23);
            this.btnMoveToDeck2.TabIndex = 0;
            this.btnMoveToDeck2.Text = ">>";
            this.btnMoveToDeck2.UseVisualStyleBackColor = true;
            this.btnMoveToDeck2.Click += new System.EventHandler(this.btnMoveToDeck2_Click);
            // 
            // btnMoveToDeck1
            // 
            this.btnMoveToDeck1.Location = new System.Drawing.Point(158, 143);
            this.btnMoveToDeck1.Name = "btnMoveToDeck1";
            this.btnMoveToDeck1.Size = new System.Drawing.Size(38, 23);
            this.btnMoveToDeck1.TabIndex = 1;
            this.btnMoveToDeck1.Text = "<<";
            this.btnMoveToDeck1.UseVisualStyleBackColor = true;
            this.btnMoveToDeck1.Click += new System.EventHandler(this.btnMoveToDeck1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 225);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(202, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(126, 225);
            this.listBox2.TabIndex = 3;
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(26, 257);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(126, 23);
            this.btnReset1.TabIndex = 4;
            this.btnReset1.Text = "Reset Deck #1";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnShuffle1
            // 
            this.btnShuffle1.Location = new System.Drawing.Point(26, 288);
            this.btnShuffle1.Name = "btnShuffle1";
            this.btnShuffle1.Size = new System.Drawing.Size(126, 23);
            this.btnShuffle1.TabIndex = 5;
            this.btnShuffle1.Text = "Shuffle Deck #1";
            this.btnShuffle1.UseVisualStyleBackColor = true;
            this.btnShuffle1.Click += new System.EventHandler(this.btnShuffle1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(202, 257);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(126, 23);
            this.btnReset2.TabIndex = 6;
            this.btnReset2.Text = "Reset Deck #2";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnShuffle2
            // 
            this.btnShuffle2.Location = new System.Drawing.Point(202, 286);
            this.btnShuffle2.Name = "btnShuffle2";
            this.btnShuffle2.Size = new System.Drawing.Size(126, 23);
            this.btnShuffle2.TabIndex = 7;
            this.btnShuffle2.Text = "Shuffle Deck #2";
            this.btnShuffle2.UseVisualStyleBackColor = true;
            this.btnShuffle2.Click += new System.EventHandler(this.btnShuffle2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deck #1 (6 Cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deck #2 (52 Cards)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShuffle2);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnShuffle1);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMoveToDeck1);
            this.Controls.Add(this.btnMoveToDeck2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveToDeck2;
        private System.Windows.Forms.Button btnMoveToDeck1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnShuffle1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnShuffle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

