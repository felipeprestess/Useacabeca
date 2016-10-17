namespace GerenciamentoDeAbelha
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
            this.lblWorkerBeeJob = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.turnos = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.proxTurno = new System.Windows.Forms.Button();
            this.relatorio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.turnos);
            this.groupBox1.Controls.Add(this.lblShifts);
            this.groupBox1.Controls.Add(this.lblWorkerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // lblWorkerBeeJob
            // 
            this.lblWorkerBeeJob.AutoSize = true;
            this.lblWorkerBeeJob.Location = new System.Drawing.Point(6, 16);
            this.lblWorkerBeeJob.Name = "lblWorkerBeeJob";
            this.lblWorkerBeeJob.Size = new System.Drawing.Size(80, 13);
            this.lblWorkerBeeJob.TabIndex = 0;
            this.lblWorkerBeeJob.Text = "Worker bee job";
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(247, 16);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(33, 13);
            this.lblShifts.TabIndex = 1;
            this.lblShifts.Text = "Shifts";
            // 
            // turnos
            // 
            this.turnos.Location = new System.Drawing.Point(250, 34);
            this.turnos.Name = "turnos";
            this.turnos.Size = new System.Drawing.Size(56, 20);
            this.turnos.TabIndex = 2;
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(9, 32);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(235, 21);
            this.workerBeeJob.TabIndex = 3;
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(9, 59);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(235, 24);
            this.assignJob.TabIndex = 4;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // proxTurno
            // 
            this.proxTurno.Location = new System.Drawing.Point(332, 12);
            this.proxTurno.Name = "proxTurno";
            this.proxTurno.Size = new System.Drawing.Size(74, 92);
            this.proxTurno.TabIndex = 1;
            this.proxTurno.Text = "Work the next shift";
            this.proxTurno.UseVisualStyleBackColor = true;
            this.proxTurno.Click += new System.EventHandler(this.proxTurno_Click);
            // 
            // relatorio
            // 
            this.relatorio.Location = new System.Drawing.Point(13, 111);
            this.relatorio.Multiline = true;
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(392, 194);
            this.relatorio.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 318);
            this.Controls.Add(this.relatorio);
            this.Controls.Add(this.proxTurno);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown turnos;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Label lblWorkerBeeJob;
        private System.Windows.Forms.Button proxTurno;
        private System.Windows.Forms.TextBox relatorio;
    }
}