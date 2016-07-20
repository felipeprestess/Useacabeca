using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    interface IStingPatrol : IWorker
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
