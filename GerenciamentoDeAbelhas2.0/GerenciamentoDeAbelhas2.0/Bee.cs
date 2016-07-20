using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciamentoDeAbelhas2._0
{
    class Bee
    {
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
                totalConsumo *=  1.35;
            return totalConsumo;
        }
    }
}
