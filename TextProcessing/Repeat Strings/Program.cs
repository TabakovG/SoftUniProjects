using System;

namespace Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string result = string.Empty;
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }

            Console.WriteLine(result);
        }
    }
}
