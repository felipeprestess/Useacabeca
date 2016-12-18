﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACasaJogo
{

    class RoomWithDoor : Room, IHasExteriorDoor
    {

        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription)
            :base(name, decoration, hidingPlaceName)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;
        public string DoorDescription{ get{ return doorDescription;} }

        private Location doorLocation;
        public Location DoorLocation
        {
            get{ return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
