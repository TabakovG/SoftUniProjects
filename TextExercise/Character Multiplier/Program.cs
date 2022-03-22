using System;

namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');

            Console.WriteLine(GetSum(inp[0], inp[1]));
        }
        static int GetSum(string first, string second)
        {
            string longerStr = first.Length >= second.Length ? first : second;
            string shorterStr = first.Length < second.Length ? first : second;

            int sum = 0;

            for (int i = 0; i < shorterStr.Length; i++)
            {
                sum += longerStr[i] * shorterStr[i];
            }

            if (longerStr.Length > shorterStr.Length)
            {
                for (int i = shorterStr.Length; i < longerStr.Length; i++)
                {
                    sum += (int)longerStr[i];
                }
            }
            return sum;
        }
    }
}
