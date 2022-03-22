using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFib(index-1));
        }
        static long RecursiveFib(int index)
        {
            if (index <= 1)
            {
                return 1;
            }            
            long fNum =0;
            for (int i = index; i > 0; i--)
            {
                fNum = RecursiveFib(index - 1) + RecursiveFib(index -2);
            }
            return fNum;
        }
    }
}
