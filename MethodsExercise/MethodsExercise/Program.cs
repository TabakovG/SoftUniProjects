using System;
using System.Linq;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintMax(num1, num2, num3));
        }

        static int PrintMax(int num1, int num2, int num3)
        {
            int[] arr = {num1, num2, num3 };
            return arr.Min();
        }
    }
}
