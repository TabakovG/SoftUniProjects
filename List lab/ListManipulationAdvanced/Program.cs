using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> initialList = new List<int>();
            initialList.AddRange(numbers);
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {

                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        bool contain = numbers.Contains(int.Parse(command[1]));
                        if (contain)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum()); 
                        break;
                    case "Filter":
                        PrintFilteredNums(command[1], int.Parse(command[2]), numbers);
                        break;

                }

                input = Console.ReadLine();
            }
            if (initialList.Count != numbers.Count)
            {
            Console.WriteLine(string.Join(" ", numbers));
            }
            else 
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (initialList[i]!=numbers[i])
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                        return;
                    }
                }
            }
        }

        private static void PrintFilteredNums(string condition, int compareNum, List<int> listItem)
        {
            List<int> filteredList = new List<int>();
            filteredList.AddRange(listItem);

            switch (condition)
            {
                case "<":
                    filteredList.RemoveAll(x => x >= compareNum);
                    Console.WriteLine(string.Join(" ", filteredList));
                    break;
                case ">":
                    filteredList.RemoveAll(x => x <= compareNum);
                    Console.WriteLine(string.Join(" ", filteredList));
                    break;
                case ">=":
                    filteredList.RemoveAll(x => x < compareNum);
                    Console.WriteLine(string.Join(" ", filteredList));
                    break;
                case "<=":
                    filteredList.RemoveAll(x => x > compareNum);
                    Console.WriteLine(string.Join(" ", filteredList));
                    break;
            }
        }

        static void PrintOddNumbers(List<int> numbers)
        {
            List<int> oddNums = new List<int>();
            oddNums.AddRange(numbers);
            oddNums.RemoveAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", oddNums));
        }

        static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenNums = new List<int>();
            evenNums.AddRange(numbers);
            evenNums.RemoveAll(x => x % 2 != 0);
            Console.WriteLine(string.Join(" ", evenNums));
        }
    }
}
