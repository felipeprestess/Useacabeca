using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmJantar
{
    class BirthdayParty : Party
    {

        public int CakeSize;

        public override int NumberOfPeople {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }


        private string cakeWriting = "";

        public string CakeWriting {
            get { return this.cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                this.cakeWriting = value;
            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            :base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }


        //Calcula o tamanho do bolo baseado na quantidade de pessoas
        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 4;
        }

        //Calcula o custo total baseado no tamanho do bolo, somando as letras acrescentadas
        public override decimal CalculateCost()
        {
            decimal CakeCost;

            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;
            return base.CalculateCost() + CakeCost;
        }

        

        
    }
}
