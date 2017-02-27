namespace SerializacaoDeBaralhos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCompareDados = new System.Windows.Forms.Button();
            this.btnThreeOfClubs = new System.Windows.Forms.Button();
            this.btnSixOfHearts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 20;
            this.listHand.Location = new System.Drawing.Point(746, 52);
            this.listHand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(226, 504);
            this.listHand.TabIndex = 0;
            // 
            // btnAsk
            // 
            this.btnAsk.Enabled = false;
            this.btnAsk.Location = new System.Drawing.Point(746, 568);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(228, 45);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask for a card";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // lblYourHand
            // 
            this.lblYourHand.AutoSize = true;
            this.lblYourHand.Location = new System.Drawing.Point(746, 25);
            this.lblYourHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourHand.Name = "lblYourHand";
            this.lblYourHand.Size = new System.Drawing.Size(83, 20);
            this.lblYourHand.TabIndex = 2;
            this.lblYourHand.Text = "Your hand";
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(18, 25);
            this.lblYourName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(87, 20);
            this.lblYourName.TabIndex = 3;
            this.lblYourName.Text = "Your name";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(356, 52);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(363, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(18, 126);
            this.txtProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(698, 301);
            this.txtProgress.TabIndex = 6;
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(18, 458);
            this.txtBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.ReadOnly = true;
            this.txtBooks.Size = new System.Drawing.Size(698, 152);
            this.txtBooks.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Game progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Books";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 638);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 638);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 638);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "save random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 638);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "load random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCompareDados
            // 
            this.btnCompareDados.Location = new System.Drawing.Point(527, 638);
            this.btnCompareDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompareDados.Name = "btnCompareDados";
            this.btnCompareDados.Size = new System.Drawing.Size(152, 35);
            this.btnCompareDados.TabIndex = 14;
            this.btnCompareDados.Text = "Compare Dados";
            this.btnCompareDados.UseVisualStyleBackColor = true;
            this.btnCompareDados.Click += new System.EventHandler(this.btnCompareDados_Click);
            // 
            // btnThreeOfClubs
            // 
            this.btnThreeOfClubs.Location = new System.Drawing.Point(696, 638);
            this.btnThreeOfClubs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThreeOfClubs.Name = "btnThreeOfClubs";
            this.btnThreeOfClubs.Size = new System.Drawing.Size(133, 35);
            this.btnThreeOfClubs.TabIndex = 15;
            this.btnThreeOfClubs.Text = "Three of Clubs";
            this.btnThreeOfClubs.UseVisualStyleBackColor = true;
            this.btnThreeOfClubs.Click += new System.EventHandler(this.btnThreeOfClubs_Click);
            // 
            // btnSixOfHearts
            // 
            this.btnSixOfHearts.Location = new System.Drawing.Point(860, 638);
            this.btnSixOfHearts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSixOfHearts.Name = "btnSixOfHearts";
            this.btnSixOfHearts.Size = new System.Drawing.Size(112, 35);
            this.btnSixOfHearts.TabIndex = 16;
            this.btnSixOfHearts.Text = "Six of Hearts";
            this.btnSixOfHearts.UseVisualStyleBackColor = true;
            this.btnSixOfHearts.Click += new System.EventHandler(this.btnSixOfHearts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 700);
            this.Controls.Add(this.btnSixOfHearts);
            this.Controls.Add(this.btnThreeOfClubs);
            this.Controls.Add(this.btnCompareDados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCompareDados;
        private System.Windows.Forms.Button btnThreeOfClubs;
        private System.Windows.Forms.Button btnSixOfHearts;
    }
}

