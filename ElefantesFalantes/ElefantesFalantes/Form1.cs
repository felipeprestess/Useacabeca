using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElefantesFalantes
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoIAm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoIAm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant arm;
            arm = lloyd;
            lloyd = lucinda;
            lucinda = arm;

        }
    }
}
