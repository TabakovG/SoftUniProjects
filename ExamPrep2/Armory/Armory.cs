using System;
using System.Collections.Generic;
using System.Linq;

namespace Armory
{
    internal class Armory
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n, n];
            int initialDeal = 65;

            FillTheMatrix(armory);

            var stats = new Dictionary<string, int>()
            {
                { "currentRow", -1},
                { "currentCol", -1},
                {"ernings", 0 }

            };

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (armory[r, c] == 'A')
                    {
                        stats["currentRow"] = r;
                        stats["currentCol"] = c;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                int nextRow = stats["currentRow"];
                int nextCol = stats["currentCol"];

                if (command == "up")
                {
                    nextRow = stats["currentRow"]-1;

                }
                else if (command == "down")
                {
                    nextRow = stats["currentRow"]+1;


                }
                else if (command == "left")
                {
                    nextCol = stats["currentCol"]-1;

                }
                else if (command == "right")
                {
                    nextCol = stats["currentCol"]+1;
                }

                armory[stats["currentRow"], stats["currentCol"]] = '-';
                if (CheckPosition(armory, nextRow, nextCol))
                {
                    Console.WriteLine("I do not need more swords!");
                    break;
                }
                stats["currentRow"] = nextRow;
                stats["currentCol"] = nextCol;
                MoveAndCollect(armory, stats);
                
                if (stats["ernings"] >= initialDeal)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    break;
                }

            }
            Console.WriteLine($"The king paid {stats["ernings"]} gold coins.");

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{armory[r, c]}");
                }
                Console.WriteLine();
            }


        }

        private static void MoveAndCollect(char[,] armory, Dictionary<string, int> stats)
        {
            if (char.IsDigit(armory[stats["currentRow"], stats["currentCol"]]))
            {
                stats["ernings"] += int.Parse(armory[stats["currentRow"], stats["currentCol"]].ToString());
                armory[stats["currentRow"], stats["currentCol"]] = 'A';
                return;
            }
            else if (armory[stats["currentRow"], stats["currentCol"]] == 'M')
            {
                armory[stats["currentRow"], stats["currentCol"]] = '-';

                for (int r = 0; r < armory.GetLength(0); r++)
                {
                    for (int c = 0; c < armory.GetLength(1); c++)
                    {
                        if (armory[r, c] == 'M')
                        {
                            stats["currentRow"] = r;
                            stats["currentCol"] = c;
                            armory[stats["currentRow"], stats["currentCol"]] = 'A';
                            return;
                        }
                    }
                }
            }
            return;
        }

        private static bool CheckPosition(char[,] armory, int row, int col)
        {
            if (row >= armory.GetLength(0) || row < 0
                || col >= armory.GetLength(1) || col < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillTheMatrix(char[,] armory)
        {
            int n = armory.GetLength(0);
            for (int r = 0; r < n; r++)
            {
                char[] readLine = Console.ReadLine().ToCharArray();
                for (int c = 0; c < n; c++)
                {
                    armory[r, c] = readLine[c];
                }
            }
        }

    }
}
