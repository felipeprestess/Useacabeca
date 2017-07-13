using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeControl_on_a_form
{
    public partial class Form1 : Form
    {
        BeeControl control = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (control == null)
            {
                control = new BeeControl() { Location = new Point(100,100) };
                Controls.Add(control);
            }
            else
            {
                using (control)
                {
                    Controls.Remove(control);
                }
                control = null;
            }
        }
    }
}
