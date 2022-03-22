using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isEqual = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int sumL = 0;
                int sumR = 0;
                for (int j = 0; j < i; j++)
                {
                    sumL += arr[j];
                }
                for (int k = i+1; k < arr.Length; k++)
                {
                    sumR += arr[k];
                }
                if (sumL == sumR)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
                
            }
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
