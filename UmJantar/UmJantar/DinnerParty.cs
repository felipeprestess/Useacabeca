using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmJantar
{
    class DinnerParty
    {
        private int numberOfPeople;
        public int NumberOfPeople {
            get{ return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyOption);
            }
        }

        private bool fancyOption;
        /*CONSTRUCTOR*/
        public DinnerParty(int numberOfPeople, bool HealthyOption, bool FancyOption)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyOption = FancyOption;
            SetHealthyOption(HealthyOption);
            CalculateCostOfDecorations(fancyOption);
        }
        public decimal CostOfBeveragesPerPerson;
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;

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

        public void CalculateCostOfDecorations(bool optionFancy)
        {
            if (optionFancy)
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
