using System;

namespace RecArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(getArea(width, height));
        }

        static int getArea(int width, int height)
        {
            return width * height;
        }
    }
}
