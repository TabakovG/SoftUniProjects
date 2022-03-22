using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int number = int.Parse(input);
                    ProcessInput(number);
                    break;
                case "real":
                    double realNum = double.Parse(input);
                    ProcessInput(realNum);
                    break;
                case "string":
                    ProcessInput(input);
                    break;
                default:
                    break;
            }
            
        }
        static void ProcessInput(int num)
        {
            Console.WriteLine(num*2);
        }
        static void ProcessInput(double num)
        {
            Console.WriteLine($"{num*1.5:f2}");
        }
        static void ProcessInput(string str)
        {
            Console.WriteLine($"${str}$");
        }

    }
}
