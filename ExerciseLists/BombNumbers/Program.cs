using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialNum = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNum)
                {
                    int startIndex = 0;
                    int elementCount = 2 * power + 1;
                    if (i - power >= 0)
                    {
                        startIndex = i - power;
                    }
                    if (startIndex + elementCount > numbers.Count - 1)
                    {
                        elementCount = numbers.Count - startIndex;
                    }



                    numbers.RemoveRange(startIndex, elementCount);
                    i = startIndex - 1;

                }
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
