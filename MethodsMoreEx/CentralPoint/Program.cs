using System;

namespace CentralPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distanceFirst = GetDistance(x1, y1);
            double distanceSecond = GetDistance(x2, y2);

            if (distanceFirst <= distanceSecond)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        static double GetDistance(double x, double y)
        {
            double result =  Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(result, 2);
        }
    }
}
