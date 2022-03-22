using System;
using System.Linq;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string topInt = "";
            for (int i = 0; i < input.Length; i++)
            {
                bool isTop = true;
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    topInt += input[i] + " ";
                }
            }
            Console.WriteLine(topInt.Trim());
        }
    }
}
