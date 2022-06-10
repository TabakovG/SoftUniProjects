using System;

namespace CreateCustomDataStructures
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();

            Console.WriteLine(myList.Count);
            myList.Add(1);
            Console.WriteLine(myList.Count);
            myList.Add(2);
            Console.WriteLine(myList.Count);
            myList.Add(3);
            Console.WriteLine(myList.Count);
            myList.Add(4);
            myList[3] = 12;
            Console.WriteLine(myList.Count);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            myList.RemoveAt(0);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(myList.Contains(2));
            Console.WriteLine(myList.Contains(222));

            myList.Insert(0, 124);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            myList.Swap(0, 1);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();


            var newStack = new CustomStack();

            Console.WriteLine(newStack.Count);
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6);

            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Peek());
            



        }
    }
}
