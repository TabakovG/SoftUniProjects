using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            while (numbers.Count > 1)
            {
                result.Add(numbers[0] + numbers[numbers.Count - 1]);
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count-1);

            }
            if (numbers.Count == 1)
            {
                result.Add(numbers[0]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
