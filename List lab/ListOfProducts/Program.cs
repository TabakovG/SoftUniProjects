using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> arr = new List<string>();
            for (int i = 0; i < num; i++)
            {
                arr.Add(Console.ReadLine());
            }
            arr.Sort();
            for (int j = 0; j < arr.Count; j++)
            {
                Console.WriteLine($"{j+1}.{arr[j]}");
            }
        }
    }
}
