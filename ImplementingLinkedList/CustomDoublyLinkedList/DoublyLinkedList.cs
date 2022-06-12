using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public int Count { get; set; }
        private ListNode Head { get; set; }
        private ListNode Tail { get; set; }

        private class ListNode
        {
            public ListNode Previous { get; set; }
            public ListNode Next { get; set; }
            public T Value { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }

        }

        public void AddFirst(T element)
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

        public void AddLast(T element)
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

        public T RemoveFirst()
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

        public T RemoveLast()
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

        public void ForEach(Action<T> action)
        {
            var currentElement = this.Head;
            while (currentElement != null)
            {
                action(currentElement.Value);
                currentElement = currentElement.Next;
            }


        }

        public T[] ToArray()
        { 
            var array = new T[this.Count];
            var currentElement = this.Head;
            for (int i = 0; i < this.Count; i++)
            { 
                array[i] = currentElement.Value;
                currentElement = currentElement.Next;
            }
            return array;
        }

        public List<T> ToList()
        {
            var list = new List<T>();
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
