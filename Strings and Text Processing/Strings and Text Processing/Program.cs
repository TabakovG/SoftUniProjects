using System;

namespace Strings_and_Text_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                int startIndexName = input.IndexOf('@')+1;
                int endIndexName = input.IndexOf('|');
                int substrLenght = endIndexName-startIndexName;

                string name = input.Substring(startIndexName, substrLenght);

                int startIndexAge = input.IndexOf('#')+1;
                int endIndexAge = input.IndexOf('*');
                int ageSubstrLenght = endIndexAge - startIndexAge;

                string age = input.Substring(startIndexAge, ageSubstrLenght);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
