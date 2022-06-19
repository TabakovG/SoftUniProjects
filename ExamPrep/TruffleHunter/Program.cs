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
            var pond = new string[n, n];
            List<string> branches = new List<string>();

            ReadTheMatrix(n, pond);

            int beaverRow = -1;
            int beaverCol = -1;
            int allBranches = 0;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (pond[r, c] == "B")
                    {
                        beaverRow = r;
                        beaverCol = c;
                    }
                    else if (char.IsLower(pond[r, c].ToCharArray().First()))
                    {
                        allBranches++;
                    }
                }
            }
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                switch (cmd)
                {
                    case "up":
                        if (beaverRow-1 >= 0)
                        {
                            int newRow = beaverRow - 1;
                            if (char.IsLower(pond[newRow, beaverCol].ToCharArray().First()))
                            {
                                var result = CollectBranch(branches, pond, allBranches, newRow, beaverCol);

                                
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "B";
                                beaverRow = newRow;
                                
                                if (result==true)
                                {
                                    PrintMatrix(pond);
                                    return;
                                }
                                else
                                {
                                    allBranches--;
                                }
                                
                            }
                            else if (pond[newRow, beaverCol] == "F")
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "-";
                                beaverRow = newRow;
                                if (beaverRow == 0)
                                {
                                    newRow = n - 1;
                                }
                                else
                                {
                                    newRow = 0;
                                }
                                if (char.IsLower(pond[newRow, beaverCol].ToCharArray().First()))
                                {
                                    var result = CollectBranch(branches, pond, allBranches, newRow, beaverCol);

                                    pond[beaverRow, beaverCol] = "-";
                                    pond[newRow, beaverCol] = "B";
                                    beaverRow = newRow;
                                    
                                    if (result == true)
                                    {
                                        PrintMatrix(pond);
                                        return;
                                    }
                                    else
                                    {
                                        allBranches--;
                                    }
                                }
                                else
                                {
                                    pond[beaverRow, beaverCol] = "-";
                                    pond[newRow, beaverCol] = "B";
                                    beaverRow = newRow;
                                }

                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "B";
                                beaverRow = newRow;
                            }
                        }
                        else if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count-1);
                        }

                        
                        break;
                    case "down":
                        if (beaverRow + 1 < n)
                        {
                            int newRow = beaverRow + 1;
                            if (char.IsLower(pond[newRow, beaverCol].ToCharArray().First()))
                            {
                                var result = CollectBranch(branches, pond, allBranches, newRow, beaverCol);
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "B";
                                beaverRow = newRow;

                                if (result == true)
                                {
                                    PrintMatrix(pond);
                                    return;
                                }
                                else
                                {
                                    allBranches--;
                                }

                            }
                            else if (pond[newRow, beaverCol] == "F")
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "-";
                                beaverRow = newRow;
                                if (beaverRow == n-1)
                                {
                                    newRow = 0;
                                }
                                else
                                {
                                    newRow = n-1;
                                }
                                if (char.IsLower(pond[newRow, beaverCol].ToCharArray().First()))

                                {
                                    var result = CollectBranch(branches, pond, allBranches, newRow, beaverCol);

                                    pond[beaverRow, beaverCol] = "-";
                                    pond[newRow, beaverCol] = "B";
                                    beaverRow = newRow;
                                    
                                    if (result == true)
                                    {
                                        PrintMatrix(pond);
                                        return;
                                    }
                                    else
                                    {
                                        allBranches--;
                                    }
                                }
                                else
                                {
                                    pond[beaverRow, beaverCol] = "-";
                                    pond[newRow, beaverCol] = "B";
                                    beaverRow = newRow;
                                }

                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[newRow, beaverCol] = "B";
                                beaverRow = newRow;
                            }
                        }
                        else if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        break;
                    case "left":
                        if (beaverCol - 1 >= 0)
                        {
                            int newCol = beaverCol - 1;
                            if (char.IsLower(pond[beaverRow, newCol].ToCharArray().First()))
                            {
                                var result = CollectBranch(branches, pond, allBranches, beaverRow, newCol);


                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "B";
                                beaverCol = newCol;
                                
                                if (result == true)
                                {
                                    PrintMatrix(pond);
                                    return;
                                }
                                else
                                {
                                    allBranches--;
                                }
                            }
                            else if (pond[beaverRow, beaverCol] == "F")
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "-";
                                beaverCol = newCol;
                                if (beaverCol == 0)
                                {
                                    newCol = n-1;
                                }
                                else
                                {
                                    newCol = 0;
                                }
                                if (char.IsLower(pond[beaverRow, newCol].ToCharArray().First()))
                                {
                                    var result = CollectBranch(branches, pond, allBranches, beaverRow, newCol);


                                    pond[beaverRow, beaverCol] = "-";
                                    pond[beaverRow, newCol] = "B";
                                    beaverCol = newCol;
                                    
                                    if (result == true)
                                    {
                                        PrintMatrix(pond);
                                        return;
                                    }
                                    else
                                    {
                                        allBranches--;
                                    }
                                }
                                else
                                {
                                    pond[beaverRow, beaverCol] = "-";
                                    pond[beaverRow, newCol] = "B";
                                    beaverCol = newCol;
                                }

                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "B";
                                beaverCol = newCol;
                            }
                        }
                        else if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        break;
                    case "right":
                        if (beaverCol + 1 < n)
                        {
                            int newCol = beaverCol + 1;
                            if (char.IsLower(pond[beaverRow, newCol].ToCharArray().First()))
                            {
                                var result = CollectBranch(branches, pond, allBranches, beaverRow, newCol);


                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "B";
                                beaverCol = newCol;
                                
                                if (result == true)
                                {
                                    PrintMatrix(pond);
                                    return;
                                }
                                else
                                {
                                    allBranches--;
                                }
                            }
                            else if (pond[beaverRow, beaverCol] == "F")
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "-";
                                beaverCol = newCol;
                                if (beaverCol == n - 1)
                                {
                                    newCol = 0;
                                }
                                else
                                {
                                    newCol = n - 1;
                                }
                                if (char.IsLower(pond[beaverRow, newCol].ToCharArray().First()))
                                {
                                    var result = CollectBranch(branches, pond, allBranches, beaverRow, newCol);


                                    pond[beaverRow, beaverCol] = "-";
                                    pond[beaverRow, newCol] = "B";
                                    beaverCol = newCol;
                                    
                                    if (result == true)
                                    {
                                        PrintMatrix(pond);
                                        return;
                                    }
                                    else
                                    {
                                        allBranches--;
                                    }
                                }
                                else
                                {
                                    pond[beaverRow, beaverCol] = "-";
                                    pond[beaverRow, newCol] = "B";
                                    beaverCol = newCol;
                                }

                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "-";
                                pond[beaverRow, newCol] = "B";
                                beaverCol = newCol;
                            }
                        }
                        else if (branches.Count > 0)
                        {
                            branches.RemoveAt(branches.Count - 1);
                        }
                        break;
                }


                cmd = Console.ReadLine();
            }

            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {allBranches} branches left.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{pond[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        private static bool CollectBranch(List<string> branches, string[,] pond, int allBranches, int newRow, int beaverCol)
        {
            branches.Add(pond[newRow,beaverCol]);
            if (allBranches - 1 == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ReadTheMatrix(int n, string[,] pond)
        {
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    pond[row, col] = input[col];
                }
            }
        }
        static void PrintMatrix(string[,] pond)
        {
            for (int i = 0; i < pond.GetLength(1); i++)
            {
                for (int j = 0; j < pond.GetLength(1); j++)
                {
                    Console.Write($"{pond[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

