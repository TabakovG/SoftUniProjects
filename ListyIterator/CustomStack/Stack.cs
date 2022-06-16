using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    internal class Stack<T> : IEnumerable<T>
    {
        private List<T> items;

        public int Count { get; private set; }

        public Stack()
        {
            this.items = new List<T> { };
            this.Count = 0;
        }

        public void Push(params T[] elements)
        {
            foreach (var e in elements)
            {
                items.Add(e);
                this.Count++;
            }
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = this.items[this.Count - 1];
                this.items.RemoveAt(this.Count - 1);
                this.Count--;
                return item;
            }
            else
            {
                Console.WriteLine("No elements");
                return default;
            }

        }
        public T Peek()
        {
            if (Count > 0)
            {
                var item = this.items[this.Count - 1];
                return item;
            }
            else
            {
                throw new ArgumentException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
