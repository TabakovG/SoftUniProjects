using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace GenericBox
{
    public class GenericBox<T> : IComparable<T> where T : IComparable<T>
    {
        private T item;
        public List<T> Elements { get; }

        public GenericBox(T item)
        {
            this.item = item;
        }
        public GenericBox(List<T> elements)
        {
            this.Elements = elements;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Elements)
            {
                sb.Append($"{item.GetType()}: {item}\r\n");
            }
            return sb.ToString().TrimEnd();
            //return $"{this.item.GetType()}: {this.item.ToString()}";
        }

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            if (indexOne < 0 || indexOne > elements.Count - 1 || indexTwo < 0 || indexTwo > elements.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                var element = elements[indexOne];
                elements[indexOne] = elements[indexTwo];
                elements[indexTwo] = element;
            }
        }
        public int CompareTo(T other)
        {
            return item.CompareTo(other);
        }


        public int CountOfGreater<T>(List<T> list, T element) where T : IComparable =>
            list.Count(word => word.CompareTo(element) > 0);

    }
}
