using System;
using System.Collections.Generic;

namespace Filter_By_Age
{
    internal class Filter_By_Age
    {
        static void Main(string[] args)
        {
            //Read the input

            Dictionary<string, int> persons = new Dictionary<string, int>();
            ReadPeopleInput(persons);
            
            //Create condition



        }

        private static void ReadPeopleInput(Dictionary<string, int> persons)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                persons[input[0]] = int.Parse(input[1]);
            }

        }
    }
}
