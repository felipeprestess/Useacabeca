using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDeLenhadores
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapJacks(Flapjack Food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(Food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(string.Format("{0}'s eating flapjacks", name));
            while (meal.Count > 0)
            {
                Console.WriteLine(string.Format("{0} eat a {1} flapjack", name, meal.Pop().ToString().ToLower()));
            }
        }
    }
}
