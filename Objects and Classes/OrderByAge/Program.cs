using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> pList = new List<Person>();

            while (command != "End")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (pList.Any(person => person.Id == token[1]))
                {
                    Person selectPeson = pList.FirstOrDefault(person => person.Id == token[1]);
                    selectPeson.Name = token[0];
                    selectPeson.Age = int.Parse(token[2]);
                }
                else
                {
                    pList.Add(new Person(token[0], token[1], int.Parse(token[2])));
                }
                command = Console.ReadLine();
            }

            pList = pList.OrderBy(c => c.Age).ToList();
            foreach (var item in pList)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Age = age;
            this.Id = id;
            this.Name = name;
        }
    }
}
