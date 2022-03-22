using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            resources["shards"] = 0;
            resources["motes"] = 0;
            resources["fragments"] = 0;
            while (!resources.Any(x => x.Value >= 250))
            {
                string[] arr = Console.ReadLine().Split();

                for (int i = 0; i < arr.Length; i+=2)
                {
                    if (resources.ContainsKey(arr[i+1].ToLower()))
                    {
                        resources[arr[i+1].ToLower()] += int.Parse(arr[i]);
                    }
                    else
                    {
                        if (junk.ContainsKey(arr[i + 1].ToLower()))
                        {
                            junk[arr[i + 1].ToLower()] += int.Parse(arr[i]);
                        }
                        else
                        {
                            junk[arr[i + 1].ToLower()] = int.Parse(arr[i]);
                        }
                    }
                    if (resources.Any(x => x.Value >= 250))
                    {
                        break;
                    }
                }
            }

            KeyValuePair<string, int> material = resources.FirstOrDefault(x => x.Value >= 250);

            if (material.Key == "shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (material.Key == "fragments")
            {
                Console.WriteLine($"Valanyr obtained!");
            }
            else if (material.Key == "motes")
            {
                Console.WriteLine($"Dragonwrath obtained!");
            }

            resources[material.Key] -= 250;

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
