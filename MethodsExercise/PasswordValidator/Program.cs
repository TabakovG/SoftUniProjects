using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int allTrue = checkLength(str) + checkContent(str) + checkDigitsCount(str);

            if (allTrue == 3)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static int checkLength(string str)
        {
            if (str.Length < 6 || str.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return 0;
            }

            return 1;
        }
        static int checkContent(string str)
        {
            
            foreach (char ch in str)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return 0;
                }
                
            }
            return 1;
        }
        static int checkDigitsCount(string str)
        {
            int digitsCount = 0;

            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    digitsCount++;
                }
            }

            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return 0;
            }

            return 1;
        }
    }
}
