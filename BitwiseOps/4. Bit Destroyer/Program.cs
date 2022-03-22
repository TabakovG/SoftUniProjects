using System;

namespace _4._Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int bitIndex = int.Parse(Console.ReadLine());

            int mask =~(1 << bitIndex);
            int result = num & mask;
            Console.WriteLine(result);
        }
    }
}
