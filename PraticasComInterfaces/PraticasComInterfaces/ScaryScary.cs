using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PraticasComInterfaces
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int scaryThingIHave;
        private int numberOfScaryThings;
        public string ScaryThingIHave {
            get 
            {
                return "I have " + numberOfScaryThings + " spiders.";
            }

        }

        public ScaryScary(string funnyThingIHave,int numberOfScaryThings)
            :base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("You can't have my " + base.FunnyThingIHave);
        }
    }
}
