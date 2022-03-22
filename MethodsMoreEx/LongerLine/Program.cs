using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lengthFirst = GetLineLength(x1, y1, x2, y2);
            double lengthSecond = GetLineLength(x3, y3, x4, y4);
            double selectedLineLength = -1;

            if (lengthFirst >= lengthSecond)
            {
                
                double distanceOne = GetDistance(x1, y1);
                double distanseSecond = GetDistance(x2, y2);
                if (distanceOne <= distanseSecond)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }

            }
            else
            {
                double distanceOne = GetDistance(x3, y3);
                double distanseSecond = GetDistance(x4, y4);
                if (distanceOne <= distanseSecond)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }

            }
        }
        static double GetLineLength(double xStart, double yStart, double xEnd, double yEnd)
        {
            double x = xEnd - xStart;
            double y = yEnd - yStart;
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(result, 2);
        }
        static double GetDistance(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(result, 2);
        }
    }
}
