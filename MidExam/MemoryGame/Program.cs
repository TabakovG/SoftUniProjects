using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            int moves = 0;
            while (input != "end")
            {
                moves++;
                int[] token = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); ;

                if (!AreIndexesValid(numbers, token))
                {
                    numbers.Insert((numbers.Count) / 2, $"-{moves}a");
                    numbers.Insert((numbers.Count) / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (numbers[token[0]] == numbers[token[1]])
                {
                    string element = numbers[token[0]];
                    numbers.Remove(element);
                    numbers.Remove(element);
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else if (numbers[token[0]] != numbers[token[1]])
                {
                    Console.WriteLine("Try again!");
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));

        }
        static bool AreIndexesValid(List<string> numbers, int[] token)
        {
            if (token[0] == token[1] || token[0] < 0 || token[1] < 0 || token[0] >= numbers.Count || token[1] >= numbers.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
