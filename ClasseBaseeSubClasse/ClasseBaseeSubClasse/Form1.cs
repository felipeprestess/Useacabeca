using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseBaseeSubClasse
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            class MySubClass : MyBaseClass
            {
                public MySubClass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
                {
                    MessageBox.Show("This is the subclass: " + baseClassNeedsThis
                        + " and " + anotherValue);
                }
            }
        }

    private void button1_Click(object sender, EventArgs e)
    { 
                class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }     }
        }
    
    
}
