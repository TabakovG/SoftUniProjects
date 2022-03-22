using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] newArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i+rotations < inputArray.Length)
                {
                    newArray[i] = inputArray[i + rotations];
                }
                else
                {
                    int multiplier = (i + rotations) / inputArray.Length;
                    newArray[i] = inputArray[i + rotations - multiplier * inputArray.Length];
                }
                
            }
            Console.WriteLine(string.Join(' ', newArray));
        }
    }
}
