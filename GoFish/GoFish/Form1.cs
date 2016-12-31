using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start game yet");
                return;
            }
            game = new Game(txtName.Text, new List<string> { "Joe", "Bob" }, txtProgress);
            btnStart.Enabled = false;
            txtName.Enabled = false;
            btnAsk.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            listHand.Items.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            txtBooks.Text = game.DescribeBooks();
            txtProgress.Text += game.DescribePlayerHands();
            txtProgress.SelectionStart = txtProgress.Text.Length;
            txtProgress.ScrollToCaret();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            txtProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                txtProgress.Text += "The winner is ..." + game.GetWinnerName();
                txtBooks.Text = game.DescribeBooks();
                btnAsk.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}
