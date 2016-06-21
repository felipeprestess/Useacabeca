using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaDeBanco
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int banco = 100;
        
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Name = "Joe", Cash = 50};
            bob = new Guy() { Name="Bob", Cash = 100};

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (banco >= 10)
            {
                banco -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        public void UpdateForm()
        {
            labelJoeCash.Text = joe.Name + " has $" + joe.Cash;
            labelBobCash.Text = bob.Name + " has $" + bob.Cash;
            bank.Text = "The bank has $" + banco;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banco += bob.GiveCash(5);
            UpdateForm(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            joe.GiveCash(bob.ReceiveCash(10));
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bob.GiveCash(joe.ReceiveCash(5));
            UpdateForm();
        }
    }
}
