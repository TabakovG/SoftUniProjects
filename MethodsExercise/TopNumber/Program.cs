using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (isTop(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isTop(int num)
        {
            int sum = 0;
            int currentNumber = num;
            bool isOdd = false;
            while (currentNumber/10 != 0 || currentNumber%10 != 0)
            {
                sum += currentNumber % 10;

                if ((currentNumber % 10)%2 != 0 )
                {
                    isOdd = true;
                }

                currentNumber /= 10;
            }
            if (sum % 8 == 0 && isOdd == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
