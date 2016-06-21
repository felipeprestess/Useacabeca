namespace ProgramaDeBanco
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
            this.labelJoeCash = new System.Windows.Forms.Label();
            this.labelBobCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bank = new System.Windows.Forms.Label();
            this.joeGiveToBob = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJoeCash
            // 
            this.labelJoeCash.AutoSize = true;
            this.labelJoeCash.Location = new System.Drawing.Point(22, 30);
            this.labelJoeCash.Name = "labelJoeCash";
            this.labelJoeCash.Size = new System.Drawing.Size(65, 13);
            this.labelJoeCash.TabIndex = 0;
            this.labelJoeCash.Text = "Joe has $50";
            // 
            // labelBobCash
            // 
            this.labelBobCash.AutoSize = true;
            this.labelBobCash.Location = new System.Drawing.Point(22, 64);
            this.labelBobCash.Name = "labelBobCash";
            this.labelBobCash.Size = new System.Drawing.Size(73, 13);
            this.labelBobCash.TabIndex = 1;
            this.labelBobCash.Text = "Bob has $100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Location = new System.Drawing.Point(22, 99);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(100, 13);
            this.bank.TabIndex = 4;
            this.bank.Text = "The bank has $100";
            // 
            // joeGiveToBob
            // 
            this.joeGiveToBob.Location = new System.Drawing.Point(25, 197);
            this.joeGiveToBob.Name = "joeGiveToBob";
            this.joeGiveToBob.Size = new System.Drawing.Size(88, 39);
            this.joeGiveToBob.TabIndex = 5;
            this.joeGiveToBob.Text = "Joe gives $10 to Bob";
            this.joeGiveToBob.UseVisualStyleBackColor = true;
            this.joeGiveToBob.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bob gives $5 to Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 260);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.joeGiveToBob);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBobCash);
            this.Controls.Add(this.labelJoeCash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe e Bob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJoeCash;
        private System.Windows.Forms.Label labelBobCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Button joeGiveToBob;
        private System.Windows.Forms.Button button4;
    }
}

