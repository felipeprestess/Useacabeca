using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDePatos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> Ducks = new List<Duck>() {
            new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 13 }

            };

            PrintDucks(Ducks);

            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            Ducks.Sort(sizeComparer);
            PrintDucks(Ducks);

            DuckComparerByKind kindComparer = new DuckComparerByKind();
            Ducks.Sort(kindComparer);
            PrintDucks(Ducks);

            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            Ducks.Sort(comparer);
            PrintDucks(Ducks);

            comparer.SortBy = SortCriteria.SizeThenKind;
            Ducks.Sort(comparer);
            PrintDucks(Ducks);

            
            
            Console.ReadKey();

        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            Console.WriteLine("End of Ducks!");
        }

        
    }
}
