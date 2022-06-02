using System;

namespace Knights_of_Honor
{
    internal class Knights_of_Honor
    {
        static void Main(string[] args)
        {
            Action<string> printSir = x => Console.WriteLine($"Sir {x}");
            var output = Console.ReadLine().Split(" ");
            foreach (var item in output)
            {
                printSir(item);
            }

        }

    }
}
