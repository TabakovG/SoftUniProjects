using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] newArr = new int[numArr.Length/2];
            int i = 0;
            for (int j = numArr.Length/4-1; j >= 0; j--)
            {
                newArr[i] = numArr[j];
                i++;
            }
            for (int k = numArr.Length-1; k >= numArr.Length*0.75; k--)
            {
                newArr[i] = numArr[k];
                i++;
            }

            int[] secondArr = new int[numArr.Length/2];
            for (int index = 0; index < secondArr.Length; index++)
            {
                secondArr[index] = numArr[index + numArr.Length/4];
                secondArr[index] = secondArr[index] + newArr[index];
            }

            Console.WriteLine(string.Join(' ', secondArr));
        }
    }
}
