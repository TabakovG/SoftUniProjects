using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, string>> dragonList = new Dictionary<string, SortedDictionary<string, string>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string name = input[1];
                string stats = $"{input[2]}:{input[3]}:{input[4]}";

                AddUpdateDragon(color, name, stats, dragonList);
            }

            foreach (var dragonType in dragonList)
            {
                Console.WriteLine($"{dragonType.Key}::({PrintAverageStats(dragonType.Key, dragonList)})");
                foreach (var dragon in dragonList[dragonType.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Split(":")[0]}, health: {dragon.Value.Split(":")[1]}, armor: {dragon.Value.Split(":")[2]}");
                }
            }

        }

        private static string PrintAverageStats(string color, Dictionary<string, SortedDictionary<string, string>> dragonList)
        {
            double averageDamage = 0;
            double averageHealth = 0;
            double averageArmor = 0;

            foreach (var dragon in dragonList[color])
            {

                double[] statsArr = dragon.Value.Split(":").Select(double.Parse).ToArray();
                averageDamage += statsArr[0];
                averageHealth += statsArr[1];
                averageArmor += statsArr[2];
            }

            averageDamage /= dragonList[color].Count;
            averageHealth /= dragonList[color].Count;
            averageArmor /= dragonList[color].Count;

            return $"{averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2}";
        }

        public static void AddUpdateDragon(string color, string name, string stats, Dictionary<string, SortedDictionary<string, string>> dragonList)
        {
            if (!dragonList.ContainsKey(color))
            {
                dragonList[color] = new SortedDictionary<string, string>();
            }
            if (!dragonList[color].ContainsKey(name))
            {
                dragonList[color][name] = "";
            }
            if (!stats.Contains("null"))
            {
                dragonList[color][name] = stats;
            }
            else
            {
                int[] Default_Stats = new int[] {45, 250, 10 };

                string[] statsArray = stats.Split(":");

                for (int i = 0; i < statsArray.Length; i++)
                {
                    if (statsArray[i] == "null")
                    {
                        statsArray[i] = Default_Stats[i].ToString();
                    }
                }

                dragonList[color][name] = string.Join(":", statsArray);
            }
        }
    }
}
