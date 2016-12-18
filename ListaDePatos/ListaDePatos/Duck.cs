using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDePatos
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size)
                return 1;
            else if (Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
