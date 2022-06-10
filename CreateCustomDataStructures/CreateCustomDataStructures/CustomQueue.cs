using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCustomDataStructures
{
    internal class CustomQueue
    {
        private const int INITIAL_CAPACITY = 4;

        private int[] items;
        public int Count { get; private set; } = 0;


        public CustomQueue()
        {
            this.items = new int[INITIAL_CAPACITY];
            this.Count = 0;
        }

        private void Resize()
        {
            int[] newArray = new int[0];
            bool resizeNeeded = false;
            if (this.Count + 1 > this.items.Length)
            {
                newArray = new int[this.items.Length * 2];
                resizeNeeded = true;
            }
            else if (this.Count <= this.items.Length / 4)
            {
                newArray = new int[this.items.Length / 2];
                resizeNeeded = true;
            }

            if (resizeNeeded)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    newArray[i] = this.items[i];
                }
                this.items = newArray;
            }

        }
        private void IsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation.Custom queue is empty.");
            }
        }

        public void Enqueue(int element)
        {
            Resize();
            this.items[this.Count] = element;
            this.Count++;
        }

        public int Dequeue()
        {
            IsEmpty();
            var element = this.items[0];
            for (int i = 0; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[this.Count - 1] = default(int);
            this.Count--;
            Resize();

            return element;
        }

        public int Peek()
        {
            IsEmpty();
            return this.items[0];
        }

        public void Clear()

        {
            IsEmpty();
            this.items = new int[4];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count ; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
