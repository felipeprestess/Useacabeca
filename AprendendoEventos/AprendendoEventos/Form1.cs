using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoEventos
{
    public partial class Form1 : Form
    {
        Pitcher pitcher;
        Ball ball = new Ball();
        Fan fan;
        public Form1()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            bat.HitTheBall(ballEventArgs);
        }
    }
}
