using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeeControl_on_a_form;

namespace SimuladorColmeiaComplexo
{
    public partial class FieldForm : Form
    {
        BeeControl beeControl;
        public FieldForm()
        {
            InitializeComponent();
            beeControl = new BeeControl();
        }

        private void FieldForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void FieldForm_Resize(object sender, EventArgs e)
        {
            beeControl.ResizeCells();
        }
    }
}
