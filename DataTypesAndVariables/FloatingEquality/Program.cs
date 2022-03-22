using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double diff = num1 - num2;
            Console.WriteLine(Math.Abs(diff) < 0.000001);
        }
    }
}
