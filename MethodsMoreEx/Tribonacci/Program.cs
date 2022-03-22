using System;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", GetTribonachiNum(num)));

        }
        static int[] GetTribonachiNum(int num)
        {
            int[] tribonacciArr = new int[num];
            tribonacciArr[0] = 1;
            for (int i = 1; i < num; i++)
            {
                int firstInLine = tribonacciArr[i - 1];
                int secInLine = (i - 2 >= 0 ? tribonacciArr[i - 2] : 0);
                int thirdInLine = (i - 3 >= 0 ? tribonacciArr[i - 3] : 0);
                tribonacciArr[i] = firstInLine + secInLine + thirdInLine;
            }
            return tribonacciArr;
        }
    }
}
