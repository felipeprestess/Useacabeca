using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeDigitacao
{
    public partial class Form1 : Form
    {
        Random random;
        Stats stats;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            stats = new Stats();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));//Trocar Random por random
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
                btnRestart.Visible = true;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 70;
                else if (timer1.Interval > 250)
                    timer1.Interval -= 20;
                else if (timer1.Interval > 100)
                    timer1.Interval -= 8;

                difficultyProgressBar.Value = 800 - timer1.Interval;
                stats.Update(true);

            }
            else
                stats.Update(false);

            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
