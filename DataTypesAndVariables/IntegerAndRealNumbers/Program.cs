using System;
using System.Numerics;

namespace IntegerAndRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSn = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;
            for (int i = 0; i < numberSn; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxValue} ({maxSnowballQuality})");

        }
    }
}
