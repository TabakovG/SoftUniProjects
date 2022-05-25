using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var continentAndContries = new Dictionary<string,Dictionary<string,List<string>>>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string cityName = input[2];

                if (!continentAndContries.ContainsKey(continent))
                {
                    continentAndContries[continent] = new Dictionary<string,List<string>>();
                }
                if (!continentAndContries[continent].ContainsKey(country))
                {
                    continentAndContries[continent][country] = new List<string>();
                }
                continentAndContries[continent][country].Add(cityName);
            }
            foreach (var cont in continentAndContries)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var item in cont.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
