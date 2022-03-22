using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> token = command.Split().ToList();

                switch (token[0])
                {
                    case "Delete":
                        int num = int.Parse(token[1]);
                        numbers.RemoveAll(x => x == num);
                        break;
                    case "Insert":
                        int element = int.Parse(token[1]);
                        int position = int.Parse(token[2]);
                        numbers.Insert(position, element);
                        break;
                }
                command = Console.ReadLine();
            }
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
