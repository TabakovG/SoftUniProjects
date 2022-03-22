using System;
using System.Linq;

namespace Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = "";
            string letters = "";
            string other = "";

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else
                {
                    other += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
