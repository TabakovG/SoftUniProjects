using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (token[0])
                {
                    case "merge":
                        Merge(input, token);
                        break;
                    case "divide":                        
                        input = Divide(input, token);
                        break;
                    default:
                        Console.WriteLine(string.Join(' ', input));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', input));

        }

        static List<string> Divide(List<string> input, string[] token)
        {
            int divideIndex = int.Parse(token[1]);
            int dividePartitions = int.Parse(token[2]);

            if (divideIndex >= 0 && divideIndex < input.Count)
            {
                string element = input[divideIndex];
                int partsLength = element.Length / dividePartitions;
                if (partsLength > 0)
                {
                    List<string> newList = new List<string>();
                    for (int i = 0; i < divideIndex; i++)
                    {
                        newList.Add(input[i]);
                    }

                    List<string> substrings = new List<string>();

                    for (int i = 0; i < element.Length; i+=partsLength)
                    {
                        if (i + partsLength > element.Length)
                        {
                            partsLength = element.Length - i;
                        }
                        substrings.Add(element.Substring(i, partsLength));
                        if (substrings.Count > dividePartitions)
                        {
                            substrings[substrings.Count - 2] = substrings[substrings.Count - 2] + substrings[substrings.Count - 1];
                            substrings.RemoveAt(substrings.Count-1);
                        }
                    }
                    newList.AddRange(substrings);
                    for (int i = divideIndex + 1; i < input.Count; i++)
                    {
                        newList.Add(input[i]);
                    }
                    return newList;
                }
                else
                {
                    return input;
                }
            }
            else
            {
                return input;
            }
        }

        static void Merge(List<string> input, string[] token)
        {
            int startIndex = int.Parse(token[1]);
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            int endIndex = int.Parse(token[2]);
            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count - 1;
            }
            string newStr = string.Empty;
            if (startIndex < input.Count && startIndex <= endIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newStr += input[i];
                }
                input.RemoveRange(startIndex, endIndex - startIndex + 1);
                input.Insert(startIndex, newStr);
            }
        }
        
    }
}
