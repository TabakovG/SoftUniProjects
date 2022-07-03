using System;

namespace Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());
            var player = new Player();
            char[,] matrix = new char[size,size];

            for (int r = 0; r < size; r++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int c = 0; c < size; c++)
                { 
                    matrix[r,c] = data[c];
                    if (data[c] == 'f')
                    {
                        player.Row = r;
                        player.Col = c;
                    }
                }
            }

            for (int i = 0; i < commandsCount; i++)
            {
                string cmd = Console.ReadLine();

                int newRow = player.Row;
                int newCol = player.Col;

                if (cmd== "up")
                {
                     newRow = player.Row -1 >= 0 ? player.Row -1 : size-1;
                    if (matrix[newRow,newCol] == 'B')
                    {
                     newRow = player.Row -2 >= 0 ? player.Row -2 : size-1;
                    }
                    else if (matrix[newRow, newCol] == 'T')
                    {
                        newRow = player.Row;
                    }
                }
                else if (cmd == "down")
                {
                     newRow = player.Row + 1 < size ? player.Row + 1 : 0;
                    if (matrix[newRow, newCol] == 'B')
                    {
                        newRow = player.Row + 2 >= 0 ? player.Row + 2 : size - 1;
                    }
                    else if (matrix[newRow, newCol] == 'T')
                    {
                        newRow = player.Row;
                    }
                }
                else if (cmd == "left")
                {
                    newCol = player.Col - 1 >= 0 ? player.Col - 1 : size - 1;
                    if (matrix[newRow, newCol] == 'B')
                    {
                        newCol = player.Col - 2 >= 0 ? player.Col - 2 : size - 1;
                    }
                    else if (matrix[newRow, newCol] == 'T')
                    {
                        newCol = player.Col;
                    }
                }
                else if (cmd=="right")
                {
                    newCol = player.Col + 1 < size ? player.Col + 1 : 0;
                    if (matrix[newRow, newCol] == 'B')
                    {
                        newCol = player.Col + 2 >= 0 ? player.Col + 2 : size - 1;
                    }
                    else if (matrix[newRow, newCol] == 'T')
                    {
                        newCol = player.Col;
                    }
                }

                matrix[player.Row, player.Col] = '-';
                player.Row = newRow;
                player.Col = newCol;
                if (matrix[player.Row, player.Col] == 'F')
                {
                    matrix[player.Row, player.Col] = 'f';
                    Console.WriteLine("Player won!");
                    PrintTheMatrix(matrix);
                    return;
                }
                else
                {
                    matrix[player.Row, player.Col] = 'f';
                }

            }
            Console.WriteLine("Player lost!");
            PrintTheMatrix(matrix);

        }

        private static void PrintTheMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }
    }
    class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Player()
        {
        }

        public Player(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
