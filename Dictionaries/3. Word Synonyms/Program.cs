using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string newKey = Console.ReadLine();
                string newSynonym = Console.ReadLine();

                if (synonyms.ContainsKey(newKey))
                {
                    synonyms[newKey].Add(newSynonym);
                }
                else
                {
                    synonyms.Add(newKey,new List<string> { newSynonym });
                }
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}
