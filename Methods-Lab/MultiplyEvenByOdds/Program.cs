using System;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while (number/10 != 0 || number%10 != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit%2 == 0)
                {
                    sumEven += Math.Abs(lastDigit);
                }
                number /= 10;
            }
            return sumEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number / 10 != 0 || number % 10 != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdd += Math.Abs(lastDigit);
                }
                number /= 10;
            }
            return sumOdd;
        }
    }
}
