using System;
using System.Collections.Generic;
using System.Linq;

namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                Console.WriteLine($"{command} = {string.Join("", command.ToCharArray().Reverse())}");

                command = Console.ReadLine();
            }

        }
    }
}
