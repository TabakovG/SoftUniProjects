using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var hash = new HashSet<Person>();
            var sortedSet = new SortedSet<Person>();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            { 
                string[] input = Console.ReadLine().Split();
                var prs = new Person(input[0], int.Parse(input[1]));
                hash.Add(prs);
                sortedSet.Add(prs);

            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hash.Count);
        }
    }
}
