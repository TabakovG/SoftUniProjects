using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> List;
        private int index;

        public ListyIterator(List<T> input)
        {
            this.List = new List<T>(input);
            index = 0;
        }

        public bool Move()
        {
            if (index + 1 >= List.Count)
            {
                Console.WriteLine(false);
                return false;
            }
            index++;
            Console.WriteLine(true);
            return true;
        }
        public void Print()
        {
            if (this.List.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.List[this.index]);
            }
        }
        public bool HasNext()
        {
            if (index + 1 >= List.Count)
            {
                Console.WriteLine(false);
                return false;
            }
            Console.WriteLine(true);
            return true;
        }
        public string PrintAll()
        {
            return string.Join(" ", List);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.List)
            {
                yield  return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
