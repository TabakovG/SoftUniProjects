using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExam
{
    internal class TilesMaster
    {
        static void Main()
        {
            Stack<int> white = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> grey = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Dictionary<string, int> tiles = new Dictionary<string, int>()
            {
                {"Sink", 40},
                {"Oven", 50},
                {"Countertop", 60},
                {"Wall", 70}
            };

            Dictionary<string, int> result = new Dictionary<string, int>()
                {
                {"Floor", 0 },
                {"Countertop", 0},
                {"Oven", 0},
                {"Sink", 0},
                {"Wall", 0},
            };

            while (white.Count > 0 && grey.Count>0)
            {
                int whiteTile = white.Pop();
                int greyTile = grey.Dequeue();

                if (whiteTile == greyTile)
                {
                    if (tiles.ContainsValue(2* whiteTile))
                    {
                        string place = tiles.First(p => p.Value == 2 * whiteTile).Key;
                        result[place]++;
                    }
                    else
                    {
                        result["Floor"]++;
                    }
                }
                else
                {
                    white.Push(whiteTile/2);
                    grey.Enqueue(greyTile);
                }
            }

            if (white.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", white)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (grey.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grey)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            foreach (var location in result.Where(r=>r.Value > 0).OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
