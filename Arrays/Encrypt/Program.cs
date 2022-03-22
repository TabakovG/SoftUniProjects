using System;
using System.Linq;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 1)
            {
                return;
            }
            string vowel = "aAeEiIoOuU";
            int[] encodedStr = new int[num];

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                int encodedValue = 0;
                foreach (var item in input)
                {
                    if (vowel.Contains(item))
                    {
                        encodedValue += (int)item * input.Length;
                    }
                    else 
                    {
                        encodedValue += (int)item / input.Length;

                    }
                }
                    encodedStr[i] = encodedValue;
            }
            Array.Sort(encodedStr);
            foreach (var element in encodedStr)
            {
                Console.WriteLine(element);
            }

           
        }
    }
}
