using System;

namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double numBase = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(calcPower(numBase,pow));
        }

        static double calcPower(double num, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
