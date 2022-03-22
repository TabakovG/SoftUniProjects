using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] token = input.Split();
                if (token[0] == "Add")
                {
                    numbers.Add(int.Parse(token[1]));
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(token[0]) + numbers[i] <= maxCapacity)
                        {
                            numbers[i] += int.Parse(token[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
