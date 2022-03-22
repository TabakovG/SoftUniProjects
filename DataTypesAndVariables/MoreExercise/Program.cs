using System;
using System.Numerics;

namespace MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputType = "";

            while (input != "END")
            {
                            
                if (BigInteger.TryParse(input, out BigInteger iNumber))
                {
                    inputType = "integer";
                }
                else if (double.TryParse(input, out double dNumber))
                {
                    inputType = "floating point";
                }
                else if (char.TryParse(input, out char charInput))
                {
                    inputType = "character";
                }
                else if (Boolean.TryParse(input, out bool booleanVal))
                {
                    inputType = "boolean";
                }
                else
                {
                    inputType = "string";
                }

                Console.WriteLine($"{input} is {inputType} type");
                Console.WriteLine(true);
                input = Console.ReadLine();
            }
        }
    }
}
