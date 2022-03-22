using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(num1, num2, @operator));
        }

        static double GetResult(double num1, double num2, char @operator)
        {
            switch (@operator)
            {
                case '/':
                    return num1 / num2;
                case '*':
                    return num1 * num2;
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                default:
                    return 0;
            }
        }
    }
}
