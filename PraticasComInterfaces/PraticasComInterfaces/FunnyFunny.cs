using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PraticasComInterfaces
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;

        public FunnyFunny(string FunnyThingIHave)
        {
            this.funnyThingIHave = FunnyThingIHave;
        }

        public string FunnyThingIHave {
            get
            {
                return "Honk Honk! I have a " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }
    }
}
