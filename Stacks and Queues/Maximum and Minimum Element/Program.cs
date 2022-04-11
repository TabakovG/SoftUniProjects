using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = input[0];


                switch (action)
                {
                    case 1:
                        int value = input[1];
                        sequence.Push(value);
                        break;
                    case 2:
                        if (sequence.Any())
                        {
                            sequence.Pop();
                        }
                        break;
                    case 3:
                        if (sequence.Any())
                        {
                            Console.WriteLine(sequence.Max());
                        }
                        break;
                    case 4:
                        if (sequence.Any())
                        {
                            Console.WriteLine(sequence.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
