using System;

namespace _2._Bit_at_Position_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int shiftedNum = num >> 1;
            int result = shiftedNum & 1;
            Console.WriteLine(result);

            int alt = (num >> 1) & 1;
        }
    }
}
