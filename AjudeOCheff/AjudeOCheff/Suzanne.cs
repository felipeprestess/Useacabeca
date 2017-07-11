using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudeOCheff
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(SuzannesSecretIngredient);
            }
        }
        private string SuzannesSecretIngredient(int amount)
        {
            return string.Format("{0} ounces of cloves", amount.ToString());
        }
    }
}
