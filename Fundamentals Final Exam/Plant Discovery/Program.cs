using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants= new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string pName = input[0];
                int pRarity = int.Parse(input[1]);

                plants[pName] = new Plant(pName, pRarity, new List<int>());
            }

            string cmd = Console.ReadLine();
            while (cmd != "Exhibition")
            {

                string[] command = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string name = command[1];

                if (plants.ContainsKey(name))
                {
                    switch (action)
                    {
                        case "Rate:":
                            { 
                                int rating = int.Parse(command[3]);
                                plants[name].Rating.Add(rating);
                            }
                            break;
                        case "Update:":
                            {
                                int rarity = int.Parse(command[3]);
                                plants[name].Rarity = rarity;
                            }
                            break;
                        case "Reset:":
                            {
                                plants[name].Rating.Clear();
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                double avgRating = item.Value.Rating.Count > 0 ? item.Value.Rating.Average() : 0;
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {avgRating:f2}");
            }

        }
    }
    class Plant
    {
        public string Name { get; set; }
        public List<int> Rating { get; set; }
        public int Rarity { get; set; }

        public Plant(string name, int rarity, List<int> rating)
        {
            this.Name = name;
            this.Rating = rating;
            this.Rarity = rarity;
        }
    }
}
