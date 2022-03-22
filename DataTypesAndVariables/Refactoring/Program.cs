using System;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= endNumber; currentNum++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < currentNum; divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
