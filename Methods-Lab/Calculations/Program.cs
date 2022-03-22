using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string @operator = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (@operator)
            {
                case "add":
                    GetSum(firstNumber, secondNumber);
                    break;
                case "subtract":
                    GetDifference(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }

        }
        static void GetSum(int first, int second) 
        {
            Console.WriteLine(first+second);
        }
        static void GetDifference(int first, int second) 
        {
            Console.WriteLine(first-second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
        static void Divide(int first, int second)
        {
            Console.WriteLine(first / second);
        }

    }
}
