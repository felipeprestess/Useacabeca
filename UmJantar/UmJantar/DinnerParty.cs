using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmJantar
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations;

        public void SetHealthyOption(bool option)
        {
            option = true;
            if (option)
                CostOfBeveragesPerPerson = 5;
            else
                CostOfBeveragesPerPerson = 20;
        }

        public void CalculateCostOfDecorations(bool optionFancy)
        {
            optionFancy = true;
            if (optionFancy)
                CostOfDecorations = (15.00M * NumberOfPeople) + 50M;
            else
                CostOfDecorations = (7.50M * NumberOfPeople) + 30M;

        }

        public decimal CalculateCost(bool option)
        {
            option = true;
            decimal total = CostOfDecorations + CostOfBeveragesPerPerson + (NumberOfPeople * CostOfFoodPerPerson);
            if (option)
                return total * .95M;
            else
                return total;
            
        }
    }
}
