namespace ACasa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGoHere = new System.Windows.Forms.Button();
            this.cbxExits = new System.Windows.Forms.ComboBox();
            this.btnGoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(31, 25);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(388, 171);
            this.txtDescription.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(31, 220);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(75, 23);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Go here:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // cbxExits
            // 
            this.cbxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExits.FormattingEnabled = true;
            this.cbxExits.Location = new System.Drawing.Point(135, 222);
            this.cbxExits.Name = "cbxExits";
            this.cbxExits.Size = new System.Drawing.Size(284, 21);
            this.cbxExits.TabIndex = 2;
            // 
            // btnGoThroughTheDoor
            // 
            this.btnGoThroughTheDoor.Location = new System.Drawing.Point(31, 265);
            this.btnGoThroughTheDoor.Name = "btnGoThroughTheDoor";
            this.btnGoThroughTheDoor.Size = new System.Drawing.Size(388, 23);
            this.btnGoThroughTheDoor.TabIndex = 3;
            this.btnGoThroughTheDoor.Text = "Go through the door";
            this.btnGoThroughTheDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughTheDoor.Click += new System.EventHandler(this.btnGoThroughTheDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.btnGoThroughTheDoor);
            this.Controls.Add(this.cbxExits);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.ComboBox cbxExits;
        private System.Windows.Forms.Button btnGoThroughTheDoor;
    }
}

