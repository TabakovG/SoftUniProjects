using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int intSeqValue = 0;
            int maxCount = 0;
            int atIndex = -1;
            string sequence = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int cuIntSeqValue = arr[i];
                int cuMaxCount = 1;
                int cuIndex = i;
                string cuSequence = arr[i].ToString();
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == cuIntSeqValue)
                    {
                        cuMaxCount++;
                        cuSequence += " " + arr[j].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
                if (cuMaxCount > maxCount || (cuMaxCount == maxCount && cuIndex < atIndex))
                {
                    maxCount = cuMaxCount;
                    atIndex = cuIndex;
                    intSeqValue = cuIntSeqValue;
                    sequence = cuSequence;

                }
            }
            Console.WriteLine(sequence);
        }
    }
}
