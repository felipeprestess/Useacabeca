using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorDeAbelhas
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get;  }

        private double peso;
        public virtual int ShiftsLeft { get { return 0; } }

        public Bee(double peso)
        {
            this.peso = peso;
        }

        public virtual double GetHoneyConsumption()
        {
            double totalConsumo;
            if (ShiftsLeft == 0)
                totalConsumo = 7.5;
            else
                totalConsumo = 9 + ShiftsLeft;
            if (peso > 150)
                totalConsumo *= 1.35;
            return totalConsumo;
        }

        public bool LookForEnemies()
        {

        }

        public int SharpenStinger(int length)
        {

        }

        public int StingerLength { get; set; }

        

        
    }
}
