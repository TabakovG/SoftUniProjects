using System;

namespace GreaterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string firstVal = Console.ReadLine();
            string secondVal = Console.ReadLine();

            switch (inputType)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(firstVal), int.Parse(secondVal))); 
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(firstVal), char.Parse(secondVal)));
                    break;
                case "string":
                    Console.WriteLine(GetMax(firstVal, secondVal));
                    break;
            }

            
        }

        static int GetMax(int v1, int v2)
        {
            return Math.Max(v1, v2);
        }
        static char GetMax(char first, char second)
        {
            return (char)Math.Max((int)first, (int)second);
        }
        static string GetMax(string first, string second)
        {
            if (string.Compare(first, second) < 0)
            {
                return second;
            }
            else if (string.Compare(first, second) > 0)
            {
                return first;
            }
            else
            {
                return first;
            }
        }
    }
}
