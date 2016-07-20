using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    class NectarCollector : Worker, INectarCollector, IStingPatrol
    {
        private int alertLevel;
        public int AlertLevel { get { return alertLevel; } }

        private int stingerLength;
        public int StingerLength { get { return stingerLength; }
            set 
            {
                stingerLength = value;
            }
        }

        public bool LookForEnemies() { }
        public int SharpenStinger(int length) { }

        public void FindFlowers(){}
        public void GatherNectar(){}
        public void ReturnToHive(){}
    }
}
