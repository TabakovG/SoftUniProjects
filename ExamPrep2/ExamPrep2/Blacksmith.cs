using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep2
{
    internal class Blacksmith
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> carbon = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Dictionary<string, int> swords = new Dictionary<string, int>()
            {
                { "Gladius",70},
                { "Shamshir",80},
                { "Katana",90},
                { "Sabre",110},
                { "Broadsword",150},
            };
            Dictionary<string, int> forgedSwords = new Dictionary<string, int>();

            /*         Console.WriteLine(String.Join(" ", steel));
                     Console.WriteLine(String.Join(" ", carbon));*/

            while (steel.Count > 0)
            {
                if (carbon.Count == 0)
                {
                    Console.WriteLine();
                    break;
                }
                int getSteel = steel.Dequeue();
                int getCarb = carbon.Pop();
                int sum = getSteel + getCarb;

                if (swords.ContainsValue(sum))
                {
                    var sword = swords.First(s => s.Value == sum);
                    if (!forgedSwords.ContainsKey(sword.Key))
                    {
                        forgedSwords[sword.Key] = 0;
                    }
                    forgedSwords[sword.Key]++;
                }
                else
                {
                    getCarb += 5;
                    carbon.Push(getCarb);
                }
            }

            if (forgedSwords.Count > 0)
            {
                Console.WriteLine($"You have forged {forgedSwords.Values.Sum()} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }
            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }
            foreach (var sw in forgedSwords.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{sw.Key}: {sw.Value}");
            }


        }
    }
}
