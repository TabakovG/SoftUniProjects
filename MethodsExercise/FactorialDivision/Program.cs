using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double division = (double)GetFactorial(num1) / GetFactorial(num2);
            Console.WriteLine($"{division:f2}");
        }
        static long GetFactorial(int num)
        {
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
