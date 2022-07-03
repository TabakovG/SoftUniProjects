using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        { 
            Random random = new Random();
            int maxNum = base.Count - 1;
            int index = random.Next(0, maxNum);
            string element = base[index];
            base.RemoveAt(index);
            return element;
        }
    }
}
