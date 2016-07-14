using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FestaAniversario
{
    class BirthdayParty
    {
        private int numberOfPeople;
        public int NumberOfPeople { get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
            }
        }
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;
        public int CakeSize;
        private bool fancyDecoration;

        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            this.fancyDecoration = fancyDecoration;
            this.numberOfPeople = numberOfPeople;
            CalculateCakeSize();
            
        }

        private string cakeWriting;

        public string CakeWriting { get; set; }
    }
}
