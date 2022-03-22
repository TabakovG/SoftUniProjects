using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lenght of side A");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter lenght of side B");
            int sideB = int.Parse(Console.ReadLine());
            int result = sideA * sideB;
            Console.WriteLine(result);

        }
    }
}
