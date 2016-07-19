using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmJantar
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        
   
        /*CONSTRUCTOR*/
        public DinnerParty(int numberOfPeople, bool OpcaoSaudavel, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(OpcaoSaudavel);
            CalculateCostOfDecorations(fancyDecorations);
        }
        

        public void SetHealthyOption(bool option)
        {
            if (option)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
                
        }


        public decimal CalculateCost(bool option)
        {
            decimal total = base.CalculateCost()  + (CostOfBeveragesPerPerson * NumberOfPeople);
            if (option)
                return total * .95M;
            else
                return total;   
        }
    }
}
