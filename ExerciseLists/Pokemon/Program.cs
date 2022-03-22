using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int currentNum = numbers[0];
                    sum += currentNum;
                    numbers[0] = numbers[numbers.Count - 1];
                    AjustListValues(numbers, currentNum);

                }
                else if (index < numbers.Count)
                {
                    int currentNum = numbers[index];
                    sum += currentNum;
                    numbers.RemoveAt(index);
                    AjustListValues(numbers,currentNum);
                    
                }
                else
                {
                    int currentNum = numbers[numbers.Count - 1];
                    sum += currentNum;
                    numbers[numbers.Count - 1] = numbers[0];
                    AjustListValues(numbers, currentNum);

                }

            }

            Console.WriteLine(sum);
        }
        static void AjustListValues(List<int> numbers, int value) 
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > value)
                {
                    numbers[i] -= value;
                }
                else
                {
                    numbers[i] += value;
                }
            }
        }
    }
}
