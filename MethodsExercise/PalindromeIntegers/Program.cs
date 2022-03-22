using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(GetReverse(input).ToString().ToLower());
            }
        }
        static bool GetReverse(string str)
        {
            string result = string.Empty;

            for (int i = str.Length-1; i >= 0; i--)
            {
                result += (char)str[i];
            }
            if (str == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
