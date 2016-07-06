using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmJantar
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private bool fancyOption;
        private int numberOfPeople;
        public int NumberOfPeople {
            get{ return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyOption);
            }
        }

       
        /*CONSTRUCTOR*/
        public DinnerParty(int numberOfPeople, bool OpcaoSaudavel, bool OpcaoChique)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyOption = OpcaoChique;
            SetHealthyOption(OpcaoSaudavel);
            CalculateCostOfDecorations(fancyOption);
        }
        public decimal CostOfBeveragesPerPerson = 0.00M;
        
        public decimal CostOfDecorations = 0.00M;

        public void SetHealthyOption(bool option)
        {
            if (option)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }

            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
                
        }

        public void CalculateCostOfDecorations(bool OpcaoChique)
        {
            fancyOption = OpcaoChique;
            if (OpcaoChique)
            {
                CostOfDecorations = (15.00M * NumberOfPeople) + 50M;
            }
            else
            {
                CostOfDecorations = (7.50M * NumberOfPeople) + 30M;
            }
                
        }

        public decimal CalculateCost(bool option)
        {
            decimal total = CostOfDecorations  + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (option)
            {
                return total * .95M;
            }
            else
            {
                return total;
            }
                
            
        }
    }
}
