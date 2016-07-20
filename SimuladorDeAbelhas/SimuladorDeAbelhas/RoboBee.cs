using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    class RoboBee : Robot, IWorker
    {
        private int shiftsToWork;
        private int shiftsToWorked;
        public int ShiftsLeft { get { return shiftsToWork - shiftsToWorked; } }
        public string Job { get; private set; }

        public bool DoThisJob(string job, int shiftsToWork){ }

        public void WorkOneShift() { }

    }
}
