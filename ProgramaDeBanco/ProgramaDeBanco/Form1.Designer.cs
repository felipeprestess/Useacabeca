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
            this.labelJoe = new System.Windows.Forms.Label();
            this.labelBob = new System.Windows.Forms.Label();
            this.labelBanco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJoe
            // 
            this.labelJoe.AutoSize = true;
            this.labelJoe.Location = new System.Drawing.Point(28, 44);
            this.labelJoe.Name = "labelJoe";
            this.labelJoe.Size = new System.Drawing.Size(44, 13);
            this.labelJoe.TabIndex = 0;
            this.labelJoe.Text = "Joe has";
            // 
            // labelBob
            // 
            this.labelBob.AutoSize = true;
            this.labelBob.Location = new System.Drawing.Point(28, 77);
            this.labelBob.Name = "labelBob";
            this.labelBob.Size = new System.Drawing.Size(46, 13);
            this.labelBob.TabIndex = 1;
            this.labelBob.Text = "Bob has";
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.Location = new System.Drawing.Point(28, 108);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(73, 13);
            this.labelBanco.TabIndex = 2;
            this.labelBanco.Text = "The bank has";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBanco);
            this.Controls.Add(this.labelBob);
            this.Controls.Add(this.labelJoe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJoe;
        private System.Windows.Forms.Label labelBob;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

