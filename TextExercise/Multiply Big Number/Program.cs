using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0 || num1 == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                char[] num1Reversed = num1.ToCharArray().Reverse().ToArray();
                string newNum = string.Empty;

                int leftToAdd = 0;
                foreach (char digit in num1Reversed)
                {
                    int digitToInt = int.Parse(digit.ToString());

                    int result = (digitToInt * num2) + leftToAdd;
                    newNum += (result%10).ToString();
                    leftToAdd = result/10;
                }
                if (leftToAdd>0)
                {
                    newNum += leftToAdd;
                }

                Console.WriteLine(string.Join("", newNum.ToCharArray().Reverse()));
            }
        }
    }
}
