using System;
using System.Collections.Generic;
using System.Linq;

namespace TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] forest = new char[n, n];
            Dictionary<char, int> truffels = new Dictionary<char, int> {
                {'B',0 },
                {'S', 0 },
                {'W',0 }
            };
            int truffelsEaten = 0;

            FillTheMatrix(forest);

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "Stop the hunt")
                {
                    break;
                }
                else if (cmd.StartsWith("Collect"))
                {
                    int row = int.Parse(cmd.Split(" ")[1]);
                    int col = int.Parse(cmd.Split(" ")[2]);

                    if (truffels.ContainsKey(forest[row, col]))
                    {
                        truffels[forest[row, col]]++;
                        forest[row, col] = '-';
                    }
                }
                else if (cmd.StartsWith("Wild_Boar"))
                {
                    int row = int.Parse(cmd.Split(" ")[1]);
                    int col = int.Parse(cmd.Split(" ")[2]);
                    string direction = cmd.Split(" ")[3];

                    truffelsEaten += BoarRun(forest, row, col, direction);
                }
            }

            Console.WriteLine($"Peter manages to harvest {truffels['B']} black, {truffels['S']} summer, and {truffels['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {truffelsEaten} truffles.");
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{forest[r,c]} ");
                }
                Console.WriteLine();
            }
        }

        private static int BoarRun(char[,] forest, int row, int col, string direction)
        {
            int truffelsEaten = 0;
            switch (direction)
            {
                case "up":
                    for (int r = row; r >= 0; r-=2)
                    {
                        truffelsEaten += BoarEat(forest, r, col);
                    }
                    break;
                case "down":
                    for (int r = row; r < forest.GetLength(0); r+=2)
                    {
                        truffelsEaten += BoarEat(forest, r, col);
                    }
                    break;
                case "left":
                    for (int c = col; c >= 0; c-=2)
                    {
                        truffelsEaten += BoarEat(forest, row, c);
                    }
                    break;
                case "right":
                    for (int c = col; c < forest.GetLength(1); c+=2)
                    {
                        truffelsEaten += BoarEat(forest, row, c);
                    }
                    break;
                default:
                    break;
            }

            return truffelsEaten;
        }

        private static int BoarEat(char[,] forest, int row, int col)
        {
            var truffels = new char[] {'B', 'S', 'W'}; 
            if (truffels.Contains(forest[row, col]))
            {
                forest[row, col] = '-';
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static void FillTheMatrix(char[,] forest)
        {
            int n = forest.GetLength(0);
            for (int r = 0; r < n; r++)
            {
                char[] readLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int c = 0; c < n; c++)
                {
                    forest[r, c] = readLine[c];
                }
            }
        }
    }
}
