using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }
        public int Count { get { return this.items.Count; } }

        public void Add(T element)
        { 
            this.items.Add(element);
        }
        public T Remove()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Box is empty!");
            }

            var element = this.items[this.items.Count-1];
            this.items.RemoveAt(this.items.Count-1);
            return element;
        }



    }
}
