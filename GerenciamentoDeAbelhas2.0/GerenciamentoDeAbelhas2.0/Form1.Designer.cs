namespace GerenciamentoDeAbelhas2._0
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 73);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(139, 23);
            this.assignJob.TabIndex = 4;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(167, 41);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(58, 20);
            this.shifts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worker bee job";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 41);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(139, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(274, 32);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(75, 89);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 142);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(337, 117);
            this.report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox report;
    }
}

