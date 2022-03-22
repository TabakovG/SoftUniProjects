using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = 1; i <= num; i++)
            {
                sum = BigInteger.Multiply(sum, i);
            }

            Console.WriteLine(sum);
        }
    }
}
