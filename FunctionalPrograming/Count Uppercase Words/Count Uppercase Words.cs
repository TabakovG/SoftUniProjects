using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                Func<string, bool> returnCapitalCase = word => char.IsUpper(word[0]);
                Console.WriteLine(string.Join("\r\n", words.Where(returnCapitalCase)));
            }
        }
    }
}
