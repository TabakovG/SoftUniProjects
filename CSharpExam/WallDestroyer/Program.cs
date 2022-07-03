using System;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] wall = new char[size, size];
            var vanko = new Vanko();
            bool success = true;
            int countOfRods = 0;

            for (int r = 0; r < size; r++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < size; c++)
                {
                    wall[r, c] = input[c];
                    if (input[c] == 'V')
                    {
                        vanko.Row = r;
                        vanko.Col = c;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                int newRow = vanko.Row;
                int newCol = vanko.Col;

                if (command == "up" && vanko.Row - 1 >= 0)
                {
                    newRow = vanko.Row - 1;
                }
                else if (command == "down" && vanko.Row + 1 < size)
                {
                    newRow = vanko.Row + 1;

                }
                else if (command == "left" && vanko.Col - 1 >= 0)
                {
                    newCol = vanko.Col - 1;
                }
                else if (command == "right" && vanko.Col + 1 < size)
                {
                    newCol = vanko.Col + 1;
                }

                if (wall[newRow, newCol] == 'V')
                {
                }
                else if (wall[newRow, newCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    countOfRods++;
                }
                else if (wall[newRow, newCol] == 'C')
                {
                    wall[vanko.Row, vanko.Col] = '*';
                    wall[newRow, newCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {GetHoles(wall)} hole(s).");
                    success = false;
                    break;
                }
                else if (wall[newRow, newCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{newRow}, {newCol}]!");
                    wall[vanko.Row, vanko.Col] = '*';
                    wall[newRow, newCol] = 'V';
                    vanko.Row = newRow;
                    vanko.Col = newCol;
                }
                else if (wall[newRow, newCol] == '-')
                {
                    wall[newRow, newCol] = 'V';
                    wall[vanko.Row, vanko.Col] = '*';
                    vanko.Row = newRow;
                    vanko.Col = newCol;

                }

                command = Console.ReadLine();
            }

            if (success)
            {
                Console.WriteLine($"Vanko managed to make {GetHoles(wall)} hole(s) and he hit only {countOfRods} rod(s).");
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(wall[r, c]);
                }
                Console.WriteLine();
            }

        }

        private static int GetHoles(char[,] wall)
        {
            int num = 0;
            for (int r = 0; r < wall.GetLength(0); r++)
            {
                for (int c = 0; c < wall.GetLength(1); c++)
                {
                    if (wall[r, c] == '*' || wall[r, c] == 'V' || wall[r, c] == 'E')
                    {
                        num++;
                    }
                }
            }
            return num;
        }
    }
    class Vanko
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
