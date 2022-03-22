using System;
using System.Linq;

namespace CondenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //for (int i = 1; i < array.Length; i++)
            //{
            //    for (int j = 1; j < array.Length; j++)
            //    {
            //        array[j-1] = array[j-1] + array[j];
            //    }
            //}
            //Console.WriteLine(array[0]);

            int[] arrayNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (arrayNums.Length > 1)
            {
            int[] condensed = new int[arrayNums.Length-1];
                for (int i = 0; i < arrayNums.Length-1; i++)
                {
                    condensed[i] = arrayNums[i] + arrayNums[i+1] ;
                }
                arrayNums = condensed;

            }
            Console.WriteLine(arrayNums[0]);
        }
    }
}
