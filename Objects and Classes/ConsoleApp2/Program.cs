using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string> 
                { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Random randomNum = new Random();
                int indexP = randomNum.Next(0, phrases.Count);
                int indexE = randomNum.Next(0, events.Count);
                int indexA = randomNum.Next(0, authors.Count);
                int indexC = randomNum.Next(0, cities.Count);

                Console.WriteLine($"{phrases[indexP]} {events[indexE]} {authors[indexA]} – {cities[indexC]}.");
            }
        }
    }
}
