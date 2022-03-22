using System;
using System.Linq;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestStartingIndex = int.MaxValue;
            string bestSubseq = "";
            int bestSubseqLength = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int cuStartIndex = i;
                int cuSeqLength = 1;
                int cuMax = inputArr[i];
                string cuString = inputArr[i].ToString() + " ";
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[j] > cuMax)
                    {
                        cuMax = inputArr[j];
                        cuSeqLength++;
                        cuString += inputArr[j].ToString() + " ";

                    }
                }
                if (cuSeqLength > bestSubseqLength || (cuSeqLength == bestSubseqLength && cuStartIndex < bestStartingIndex))
                {
                    bestStartingIndex = cuStartIndex;
                    bestSubseq = cuString;
                    bestSubseqLength = cuSeqLength;
                }
            }
            Console.WriteLine(bestSubseq);
        }
    }
}
