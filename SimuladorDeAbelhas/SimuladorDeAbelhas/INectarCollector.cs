using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
