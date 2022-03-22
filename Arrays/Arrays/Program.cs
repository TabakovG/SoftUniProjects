using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numArray = new int[num];
            for (int i = 0; i < num; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{string.Join(' ', numArray)}");
            Console.WriteLine($"{numArray.Sum()}");
    }
}
}
