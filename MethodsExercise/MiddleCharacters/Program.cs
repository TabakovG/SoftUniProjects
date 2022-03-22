using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddle(input);
        }
        static void PrintMiddle(string str)
        {
            if (str.Length % 2 == 0)
            {
                Console.WriteLine($"{(char)str[str.Length / 2 - 1]}{(char)str[str.Length / 2]}");
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }
        }
    }
}
