using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> defense = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Reverse());

            for (int wave = 1; wave <= num; wave++)
            {
                Stack<int> attack = new Stack<int>(
                    Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));

                if (wave % 3 == 0 && defense.Count > 0)
                {
                    List<int> list = defense.ToList();
                    list.Add(int.Parse(Console.ReadLine()));
                    list.Reverse();
                    defense = new Stack<int>(list);
                }

                while (attack.Count > 0 && defense.Count > 0)
                {
                    int plate = defense.Pop();
                    int orc = attack.Pop();
                    int result = plate - orc;
                    if (result > 0)
                    {
                        defense.Push(result);
                    }
                    else if (result < 0)
                    {
                        attack.Push(orc - plate);
                    }
                }

                
                if (attack.Count > 0 && defense.Count == 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ", attack)}");
                    return;
                }
            }
            
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", defense)}");
                return;
            
        }
    }
}
