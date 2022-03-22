using System;
using System.Collections.Generic;
using System.Linq;

namespace BitwiseOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());

            List<int> bitwise = new List<int>();

            while (num != 0)
            {
                bitwise.Add(num%2);
                num /= 2;
            }
            Console.WriteLine(bitwise.Where(x=>x==bit).Count());
        }
    }
}
