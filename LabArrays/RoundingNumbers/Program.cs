using System;
//using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = Console.ReadLine().Split(" ");
            double[] numArray = new double[strArray.Length];

            //double[] numArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = double.Parse(strArray[i]);
                Console.WriteLine($"{numArray[i]} => {Math.Round(numArray[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
