using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (hand1.Count > 0 && hand2.Count>0)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand2[0]);
                    hand1.Add(hand1[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] == hand2[0])
                {
                    
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] < hand2[0])
                {
                    hand2.Add(hand1[0]);
                    hand2.Add(hand2[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
            }
            string winer = (hand1.Count > hand2.Count) ? "First" : "Second";
            int sum = (hand1.Count > hand2.Count) ? hand1.Sum() : hand2.Sum();

            Console.WriteLine($"{winer} player wins! Sum: {sum}");
        }

        
    }
}
