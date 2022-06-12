using System;

namespace BoxOfT
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();

            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Count);
            box.Remove();
            Console.WriteLine(box.Count);


        }
    }
}
