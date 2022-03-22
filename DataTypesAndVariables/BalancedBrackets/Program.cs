using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            string check = "";
            for (int i = 0; i < nLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(" || input == ")")
                {
                    check += input;
                }

            }
            for (int j = 0; j < check.Length; j += 2)
            {
                if (check[j].ToString() != "(" || check[j + 1].ToString() != ")")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

            }

            Console.WriteLine("BALANCED");


        }
    }
}
