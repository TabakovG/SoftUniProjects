using System;

namespace _3._P_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int bitIndex = int.Parse(Console.ReadLine());

            int result = (num >> bitIndex) & 1;
            Console.WriteLine(result);
        }
    }
}
