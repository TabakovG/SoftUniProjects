using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                PrintTop(i);
                Console.WriteLine();
            }
            for (int j = num; j > 0; j--)
            {
                PrintBottom(j);
                Console.WriteLine();
            }

        }

        static void PrintBottom(int num)
        {
            for (int i = 1; i < num; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void PrintTop(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
