using System;
using System.Linq;

namespace Warships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            var matrix = new char[num, num];
            int playerOneShips = 0;
            int playerTwoShips = 0;

            for (int r = 0; r < num; r++)
            {
                char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int c = 0; c < num; c++)
                {
                    matrix[r, c] = data[c];
                    if (data[c] == '<')
                    {
                        playerOneShips++;
                    }
                    else if (data[c] == '>')
                    {
                        playerTwoShips++;
                    }
                }
                Console.WriteLine();
            }
            int totalShips = playerOneShips + playerTwoShips;

            for (int i = 0; i < inputs.Length; i++)
            {
                int[] coordinates = inputs[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int x = coordinates[0];
                int y = coordinates[1];

                if (IndexIsValid(x, num) && IndexIsValid(y, num))
                {
                    if (matrix[x, y] == '<')
                    {
                        playerOneShips--;
                    }
                    else if (matrix[x, y] == '>')
                    {
                        playerTwoShips--;
                    }
                    else if (matrix[x,y] == '#')
                    {
                        for (int r = x-1; r <= x+1; r++)
                        {
                            for (int c = y-1; c <= y+1; c++)
                            {
                                if (IndexIsValid(r, num) && IndexIsValid(c, num))
                                {
                                    if (matrix[r, c] == '<')
                                    {
                                        playerOneShips--;
                                    }
                                    else if (matrix[r, c] == '>')
                                    {
                                        playerTwoShips--;
                                    }
                                    matrix[r, c] = 'X';
                                }
                            }
                        }
                    }
                    matrix[x, y] = 'X';

                    if (playerOneShips == 0 || playerTwoShips == 0)
                    {
                        var winner = playerOneShips > playerTwoShips ? "One" : "Two";
                        Console.WriteLine($"Player {winner} has won the game! {totalShips-playerOneShips-playerTwoShips} ships have been sunk in the battle.");
                        return;
                    }


                }

            }

            Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");

        }

        private static bool IndexIsValid(int x, int num)
        {
            return x >= 0 && x < num;
        }
    }
}
