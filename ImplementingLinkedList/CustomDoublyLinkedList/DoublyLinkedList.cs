using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public int Count { get; set; }
        private ListNode Head { get; set; }
        private ListNode Tail { get; set; }

        private class ListNode
        {
            public ListNode Previous { get; set; }
            public ListNode Next { get; set; }
            public int Value { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }

        }

        public void AddHead(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var previousHead = this.Head;
                var newHead = new ListNode(element);
                this.Head = newHead;
                newHead.Next = previousHead;
                previousHead.Previous = newHead;
            }
            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var previousTail = this.Tail;
                var newTail = new ListNode(element);
                this.Tail = newTail;
                newTail.Previous = previousTail;
                previousTail.Next = newTail;
            }
            this.Count++;
        }

        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (this.Count == 1)
            {
                var element = this.Head.Value;
                this.Head = this.Tail = null;
                this.Count--;
                return element;
            }
            else
            {
                var firstRemoved = this.Head;
                this.Head = this.Head.Next;
                firstRemoved.Next = null;
                this.Head.Previous = null;
                this.Count--;
                return firstRemoved.Value;
            }
        }

        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (this.Count == 1)
            {
                var value = this.Tail.Value;
                this.Head = this.Tail = null;
                this.Count--;
                return value;
            }
            else
            {
                var lastRemoved = this.Tail;
                this.Tail = lastRemoved.Previous;
                lastRemoved.Previous = null;
                this.Tail.Next = null;
                this.Count--;
                return lastRemoved.Value;
            }

        }

        public void ForEach(Action<int> action)
        {
            var currentElement = this.Head;
            while (currentElement != null)
            {
                action(currentElement.Value);
                currentElement = currentElement.Next;
            }


        }

        public int[] ToArray()
        { 
            var array = new int[this.Count];
            var currentElement = this.Head;
            for (int i = 0; i < this.Count; i++)
            { 
                array[i] = currentElement.Value;
                currentElement = currentElement.Next;
            }
            return array;
        }

        public List<int> ToList()
        {
            var list = new List<int>();
            var currentElement = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                list.Add(currentElement.Value);
                currentElement = currentElement.Next;
            }
            return list;
        }

        public override string ToString()
        {
            var currentElement = this.Head;
            var text = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                text.Append(currentElement.Value.ToString());
                text.Append("<-->");
                currentElement = currentElement.Next;
            }
            return text.ToString().TrimEnd('<','>','-');
        }

    }
}
