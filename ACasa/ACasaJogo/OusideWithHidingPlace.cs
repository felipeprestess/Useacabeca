using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACasaJogo
{
    class OusideWithHidingPlace : Outside, IHidingPlace
    {
        public OusideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HindingPlaceName { get { return hidingPlaceName;} }

        public override string Description
        {
            get { return base.Description + " Someone could hide " + hidingPlaceName + ".";}
        }
    }
}
