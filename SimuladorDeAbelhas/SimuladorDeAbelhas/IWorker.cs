﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    interface IWorker
    {
        string Job { get;}
        int ShiftsLeft { get; }
        void DoThisJob(string job, int shifts);
        void WorkOneShift();
    }
}
