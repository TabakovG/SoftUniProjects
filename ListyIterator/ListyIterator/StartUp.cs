using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            elements.RemoveAt(0);
            var listy = new ListyIterator<string>(elements);

            var input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {
                    case "Move":
                        listy.Move();
                        break; 
                    case "Print":
                        listy.Print();
                        break; 
                    case "HasNext":
                        listy.HasNext();
                        break;
                    case "PrintAll":
                        Console.WriteLine(listy.PrintAll());
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
