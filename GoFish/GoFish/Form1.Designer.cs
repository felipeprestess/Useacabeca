﻿namespace GoFish
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
            this.listHand = new System.Windows.Forms.ListBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.lblYourHand = new System.Windows.Forms.Label();
            this.lblYourName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(497, 34);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(152, 329);
            this.listHand.TabIndex = 0;
            // 
            // btnAsk
            // 
            this.btnAsk.Enabled = false;
            this.btnAsk.Location = new System.Drawing.Point(497, 369);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(152, 29);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask for a card";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // lblYourHand
            // 
            this.lblYourHand.AutoSize = true;
            this.lblYourHand.Location = new System.Drawing.Point(497, 16);
            this.lblYourHand.Name = "lblYourHand";
            this.lblYourHand.Size = new System.Drawing.Size(56, 13);
            this.lblYourHand.TabIndex = 2;
            this.lblYourHand.Text = "Your hand";
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(12, 16);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(58, 13);
            this.lblYourName.TabIndex = 3;
            this.lblYourName.Text = "Your name";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(237, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(242, 22);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(12, 82);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(467, 197);
            this.txtProgress.TabIndex = 6;
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(12, 298);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.ReadOnly = true;
            this.txtBooks.Size = new System.Drawing.Size(467, 100);
            this.txtBooks.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Game progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Books";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblYourName);
            this.Controls.Add(this.lblYourHand);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.listHand);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Label lblYourHand;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

