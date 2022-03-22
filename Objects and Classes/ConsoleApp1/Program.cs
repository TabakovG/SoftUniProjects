using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = { "A", "d" };


            int num = int.Parse(Console.ReadLine());

                Random randomNum = new Random();
            for (int i = 0; i < num; i++)
            {
                int indexP = randomNum.Next(0, phrases.Count);
                int indexE = randomNum.Next(0, events.Count);
                int indexA = randomNum.Next(0, authors.Count);
                int indexC = randomNum.Next(0, cities.Count);

                Console.WriteLine($"{phrases[indexP]} {events[indexE]} {authors[indexA]} – {cities[indexC]}.");
            }
        }
    }
}
