using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    internal class Threeuple<T1, T2, T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public Threeuple(T1 element1, T2 element2, T3 element3)
        {
            this.Item1 = element1;
            this.Item2 = element2;
            this.Item3 = element3;
        }

        public override string ToString()
        {
            return Item1 + " -> " + Item2 + " -> " + Item3;
        }
    }
}
