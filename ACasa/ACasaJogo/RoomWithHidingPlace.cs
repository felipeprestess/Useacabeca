using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACasaJogo
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(decoration, name)
        {
            this.hidingPlaceName = hidingPlaceName;
        }
        private string hidingPlaceName;
        public string HindingPlaceName
        {
            get
            {
                return hidingPlaceName;
            }
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + hidingPlaceName + ".";
            }
        }
    }
}
