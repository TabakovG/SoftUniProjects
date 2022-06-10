using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCustomDataStructures
{
    public class MyList
    {
        private const int INITAL_CAPACITY = 2;

        private int[] items { get; set; }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set 
            {
                ValidateIndex(index);
                items[index] = value;
            }
        }
        public MyList()
        {
            this.items = new int[INITAL_CAPACITY];
        }

        //Internal Modification methods
        // ==========================================================================

        private void ValidateIndex(int index)
        {
            if (index<0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ResizeIfNeeded()
        {
            if (this.items.Length == Count)
            {
                int[] newList = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                { 
                    newList[i] = this.items[i];
                }
                this.items = newList;
            }
        }

        private void Shrink()
        {
            if (this.items.Length/4 >= this.Count)
            {
                int[] newList = new int[this.items.Length / 2];
                for (int i = 0; i < newList.Length; i++)
                {
                    newList[i] = this.items[i];
                }
                this.items = newList;
            }
        }

        //External Modification methods
        // ==========================================================================

        public void Add(int element)
        { 
            ResizeIfNeeded();
            this.items[Count] = element;
            Count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);
            var returnValue = this.items[index];
            for (int i = index; i < this.Count -1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[this.Count - 1] = default(int);
            this.Count--;
            Shrink();
            return returnValue;
        }

        public void Insert(int index, int value)
        {
            ValidateIndex(index);
            ResizeIfNeeded();
            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
            this.items[index] = value;
            this.Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            var firstElement = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = firstElement;
        }

    }
}
