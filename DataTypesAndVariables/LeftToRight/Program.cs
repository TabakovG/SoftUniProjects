using System;
using System.Numerics;

namespace LeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            for (int iterations = 0; iterations < numLines; iterations++)
            {
                string firstNum = "";
                string secondNum = "";
                int sumFirst = 0;
                int sumSecond = 0;
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ' ')
                    {
                        for (int j = 0; j < i; j++)
                        {
                            firstNum += input[j];
                            if (input[j].ToString() != "-")
                            {
                            sumFirst += int.Parse(input[j].ToString());
                            }
                        }
                        for (int k = i+1; k < input.Length; k++)
                        {
                            secondNum += input[k];
                            if (input[k].ToString() != "-")
                            {
                                sumSecond += int.Parse(input[k].ToString());
                            }
                        }
                    }
                }
                if (BigInteger.Parse(firstNum) > BigInteger.Parse(secondNum))
                {
                    Console.WriteLine(sumFirst);
                }
                else
                {
                    Console.WriteLine(sumSecond);
                }

            }
        }
    }
}
