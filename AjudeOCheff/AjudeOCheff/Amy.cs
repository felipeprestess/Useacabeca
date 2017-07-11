using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudeOCheff
{
    class Amy
    {
        public GetSecretIngredient AmysSecretIngredientMethod { get { return new GetSecretIngredient(AmysSecretIngredient); } }
        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
                return string.Format("{0} cans of sardines -- you need more!", amount.ToString());
            else
                return string.Format("{0} cans of sardines",amount.ToString());
        }
    }
}
