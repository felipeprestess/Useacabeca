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
    public partial class HiveForm : Form
    {
        BeeControl beeControl;
        
        public HiveForm()
        {
            InitializeComponent();
            beeControl = new BeeControl();
            BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_,
                ClientRectangle.Width, ClientRectangle.Height);
        }

        private void HiveForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void HiveForm_Resize(object sender, EventArgs e)
        { 
            beeControl.ResizeCells();
        }

       
    }
}
