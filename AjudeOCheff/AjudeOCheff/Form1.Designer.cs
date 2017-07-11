namespace AjudeOCheff
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
            this.useIngredient = new System.Windows.Forms.Button();
            this.getSuzanne = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.getAmy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(12, 12);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(160, 23);
            this.useIngredient.TabIndex = 0;
            this.useIngredient.Text = "Get the ingredient";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // getSuzanne
            // 
            this.getSuzanne.Location = new System.Drawing.Point(12, 41);
            this.getSuzanne.Name = "getSuzanne";
            this.getSuzanne.Size = new System.Drawing.Size(208, 23);
            this.getSuzanne.TabIndex = 1;
            this.getSuzanne.Text = "Get Suzanne\'s Delegate";
            this.getSuzanne.UseVisualStyleBackColor = true;
            this.getSuzanne.Click += new System.EventHandler(this.getSuzanne_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(178, 13);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(42, 20);
            this.amount.TabIndex = 2;
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(12, 70);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(208, 23);
            this.getAmy.TabIndex = 3;
            this.getAmy.Text = "Get Amy\'s Delegate";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 106);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getSuzanne);
            this.Controls.Add(this.useIngredient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secrets Ingredients";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.Button getSuzanne;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button getAmy;
    }
}

