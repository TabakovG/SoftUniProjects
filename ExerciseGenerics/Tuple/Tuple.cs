using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    internal class Tuple<T1,T2>
    {

        public T1 item1 { get; set; }
        public T2 item2 { get; set; }

        public Tuple(T1 element1 , T2 element2)
        {
            this.item1 = element1;
            this.item2 = element2;
        }

        public override string ToString()
        {
            return item1 + " -> " + item2;
        }
    }
}
