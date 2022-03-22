using System;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i])%2 == 0)
                {
                    sum += int.Parse(input[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
