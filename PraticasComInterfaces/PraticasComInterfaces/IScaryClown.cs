using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticasComInterfaces
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
