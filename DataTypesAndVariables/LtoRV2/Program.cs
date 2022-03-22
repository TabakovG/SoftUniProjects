using System;
using System.Numerics;

namespace LtoRV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            for (int iterations = 0; iterations < numLines; iterations++)
            {
                string input = Console.ReadLine();
                string[] numbersArray = input.Split(' ');
                BigInteger num1 = BigInteger.Parse(numbersArray[0]);
                BigInteger num2 = BigInteger.Parse(numbersArray[1]);
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < numbersArray[0].Length; i++)
                {
                    if (numbersArray[0][i] != "-")
                    {

                    }
                }
            }
        }
    }
}
