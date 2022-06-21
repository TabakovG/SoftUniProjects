using System;

namespace PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] chessboard = new string[8, 8];
            string fieldLetter = "abcdefgh";

            for (int r = 0; r < 8; r++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < 8; c++)
                {
                    chessboard[r, c] = input[c].ToString();
                }
                Console.WriteLine();
            }

            var white = new Pawn(chessboard, "w");
            var black = new Pawn(chessboard, "b");


            while (true)
            {
                if (WhiteMove(chessboard, white, black))
                {
                    return;
                }
                if (BlackMove(chessboard, white, black))
                {
                    return;
                }

            }


        }

        static bool BlackMove(string[,] chessboard, Pawn white, Pawn black)
        {
            string coordinates = "abcdefgh";
            int nextRow = black.Row + 1;
            int nextCol = black.Column;
            if (nextRow == white.Row)
            {
                if (black.Column - 1 == white.Column || black.Column + 1 == white.Column)
                {
                    nextCol = white.Column;
                    black.Row = nextRow;
                    black.Column = nextCol;

                    Console.WriteLine($"Game over! Black capture on {coordinates[black.Column]}{black.Row + 1}.");
                    return true;
                }
                else
                {
                    black.Row = nextRow;
                    black.Column = nextCol;
                    return false;
                }
            }
            else if (nextRow == 7)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {coordinates[black.Column]}1.");
                return true;
            }
            else
            {
                black.Row = nextRow;
                black.Column = nextCol;
                return false;
            }
        }

        static bool WhiteMove(string[,] chessboard, Pawn white, Pawn black)
        {
            string coordinates = "abcdefgh";
            int nextRow = white.Row - 1;
            int nextCol = white.Column;
            if (nextRow == black.Row)
            {
                if (white.Column - 1 == black.Column || white.Column + 1 == black.Column)
                {
                    nextCol = black.Column;
                    white.Row = nextRow;
                    white.Column = nextCol;

                    Console.WriteLine($"Game over! White capture on {coordinates[white.Column]}{8 - white.Row}.");
                    return true;
                }
                else
                {
                    white.Row = nextRow;
                    white.Column = nextCol;
                    return false;
                }
            }
            else if (nextRow == 0)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {coordinates[white.Column]}8.");
                return true;
            }
            else
            {
                white.Row = nextRow;
                white.Column = nextCol;
                return false;
            }
        }
    }
    class Pawn
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Color { get; set; }

        public Pawn(string[,] chessboard, string color)
        {
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int c = 0; c < chessboard.GetLength(1); c++)
                {
                    if (chessboard[r, c] == color)
                    {
                        this.Row = r;
                        this.Column = c;
                        if (color == "b")
                        {
                            this.Color = "Black";
                        }
                        else
                        {
                            this.Color = "White";
                        }
                    }
                }
            }


        }
    }
}
