using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            string check = "";
            bool isBalanced = false;
            if (nLines > 1)
            {

                for (int i = 0; i < nLines; i++)
                {
                    string input = Console.ReadLine();
                    if (input == "(" || input == ")")
                    {
                        check += input;
                    }

                }
                if (check.Length % 2 == 0)
                {
                    isBalanced = true;
                    for (int j = 0; j < check.Length; j += 2)
                    {
                        if (check[j].ToString() != "(" || check[j + 1].ToString() != ")")
                        {
                            isBalanced = false;
                        }

                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
