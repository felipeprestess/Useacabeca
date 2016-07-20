using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SimuladorDeAbelhas
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
            :base(275)
        {
            this.workers = workers;
        }

        public bool AssingWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
                return false;
        }

        public string WorkTheNextShift() 
        {
            double totalDosConsumos = 0;
            for (int i = 0; i < workers.Length; i++)
                totalDosConsumos += workers[i].GetHoneyConsumption();
            totalDosConsumos += GetHoneyConsumption();

            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + "finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '" +
                            workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft
                            + " more shifts\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with '"
                            + workers[i].CurrentJob + "' after this shifts\r\n ";
            }
            report += "Total honey consumption: " + totalDosConsumos + " units";
            return report;
        }


        public override double GetHoneyConsumption()
        {
            double totalConsumo = 0;
            double maiorConsumo = 0;
            int qtdOperariasTrabalhando = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > maiorConsumo)
                    maiorConsumo = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    qtdOperariasTrabalhando++;
            }
            totalConsumo += maiorConsumo;

            if (qtdOperariasTrabalhando >= 3)
                totalConsumo += 30;
            else
                totalConsumo += 20;
            return totalConsumo;
        }

        private void DefendTheHive(IStingPatrol pratoller)
        {
            
        }
    }
}
