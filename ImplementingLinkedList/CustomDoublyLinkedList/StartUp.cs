using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList();

            list.AddHead(2);
            list.AddHead(3);
            list.AddHead(4);
            Console.WriteLine();
            list.AddLast(5);
            list.AddLast(6);

            list.ForEach(x => Console.WriteLine(x));

            list.RemoveLast();
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            list.RemoveFirst();
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine(String.Join(", ", list.ToArray()));
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", list.ToList()));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(list.ToString());

        }
    }
}
