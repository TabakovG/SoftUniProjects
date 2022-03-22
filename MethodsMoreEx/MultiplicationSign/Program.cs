using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFinalSign(num1, num2, num3));
        }
        static string GetFinalSign(int num1, int num2, int num3)
        {
            int[] arr = { num1, num2, num3 };
            int negativeCount = 0;

            foreach (int n in arr)
            {
                if (n == 0)
                {
                    return "zero";
                }
                else if (n < 0)
                {
                    negativeCount++;
                }

            }
            if (negativeCount % 2 == 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
    }
}
