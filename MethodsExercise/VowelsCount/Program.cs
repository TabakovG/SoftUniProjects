using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(getVowels(input));
        }
        static int getVowels(string str)
        { 
            string compare = "aAeEoOuUiI";
            int count = 0;
            foreach (var item in str)
            {
                if (compare.Contains(item))
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
