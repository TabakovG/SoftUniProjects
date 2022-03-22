using System;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) % 2 == 0)
                {
                    sumEven += int.Parse(input[i]);
                }
                else
                {
                    sumOdd += int.Parse(input[i]);
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
