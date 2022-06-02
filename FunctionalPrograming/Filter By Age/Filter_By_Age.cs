using System;
using System.Collections.Generic;
using System.Linq;

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

            Func<KeyValuePair<string, int>, bool> filter = x => false;
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (condition == "younger")
            {
                filter = x => x.Value < age;
            }
            else if (condition == "older") 
            {
                filter = x => x.Value >= age;
            }

            var filteredPersons = persons.Where(filter);


            //Print result

            Action<KeyValuePair<string,int>> printInfo = x => Console.WriteLine(x.Key);
            string requestedInfo = Console.ReadLine();
            if (requestedInfo == "name age")
            { 
                printInfo = x => Console.WriteLine($"{x.Key} - {x.Value}");
            }
            else if (requestedInfo == "name")
            {
                printInfo = x => Console.WriteLine($"{x.Key}");
            }
            else if (requestedInfo == "age")
            {
                printInfo = x => Console.WriteLine($"{x.Value}");
            }

            foreach (var item in filteredPersons)
            {
                printInfo(item);
            }

        }

        private static void ReadPeopleInput(Dictionary<string, int> persons)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                persons[input[0]] = int.Parse(input[1]);
            }

        }
    }
}
