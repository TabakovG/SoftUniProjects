using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main()
        {
            string[] cmd = Console.ReadLine().Split(' ');
            var persons = new List<Person>();

            while (cmd[0] != "END")
            {
                //"{name} {age} {town}"
                persons.Add(new Person(cmd[0], int.Parse(cmd[1]), cmd[2]));

                cmd = Console.ReadLine().Split(' ');
            }

            int num = int.Parse(Console.ReadLine());
            var personToCompare = persons[num - 1];
            //"{count of matches} {number of not equal people} {total number of people}"

            int countMatches = persons.Where(x => x.CompareTo(personToCompare) == 0).Count();
            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notEqual = persons.Count - countMatches;
                Console.WriteLine($"{countMatches} {notEqual} {persons.Count}");
            }
        }
    }
}
