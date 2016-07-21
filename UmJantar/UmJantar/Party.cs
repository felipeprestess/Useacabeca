using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmJantar
{
    public class Party
    {
        public Party(int numberOfPeople, bool fancyDecoration)
        {
            this.fancyDecorations = fancyDecoration;
            this.NumberOfPeople = numberOfPeople; 
        }
        private bool fancyDecorations;
        const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0.00M;
        
        private int numberOfPeople;
        

        public virtual int  NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool OpcaoChique)
        {
            fancyDecorations = OpcaoChique;
            if (OpcaoChique)
                CostOfDecorations = (15.00M * NumberOfPeople) + 50M;
            else
                CostOfDecorations = (7.50M * NumberOfPeople) + 30M;

        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);

            if (NumberOfPeople > 12)
                TotalCost += 100M;
            return TotalCost;
        }
    }
}
