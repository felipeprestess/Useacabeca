namespace FormularioColorido
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
            this.button1 = new System.Windows.Forms.Button();
            this.escolha = new System.Windows.Forms.CheckBox();
            this.frasecolorida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change the color if the box is checked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // escolha
            // 
            this.escolha.AutoSize = true;
            this.escolha.Location = new System.Drawing.Point(129, 26);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(132, 17);
            this.escolha.TabIndex = 1;
            this.escolha.Text = "Enable color changing";
            this.escolha.UseVisualStyleBackColor = true;
            this.escolha.CheckedChanged += new System.EventHandler(this.escolha_CheckedChanged);
            // 
            // frasecolorida
            // 
            this.frasecolorida.AutoSize = true;
            this.frasecolorida.BackColor = System.Drawing.Color.Red;
            this.frasecolorida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frasecolorida.Location = new System.Drawing.Point(25, 87);
            this.frasecolorida.Name = "frasecolorida";
            this.frasecolorida.Size = new System.Drawing.Size(236, 15);
            this.frasecolorida.TabIndex = 2;
            this.frasecolorida.Text = "Press the button to change my color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.frasecolorida);
            this.Controls.Add(this.escolha);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with if/else statements!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox escolha;
        private System.Windows.Forms.Label frasecolorida;
    }
}

