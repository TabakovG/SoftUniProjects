using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            /*Person person1 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;

            Person person2 = new Person() { Name = "George", Age = 18 };

            Person person3 = new Person() { Name = "Jose", Age = 43 };

            Console.WriteLine(person1.Name + " " + person1.Age);
            Console.WriteLine(person2.Name + " " + person2.Age);
            Console.WriteLine(person3.Name + " " + person3.Age);

            Person person4 = new Person(33);
            Console.WriteLine();
            Console.WriteLine(person4.Name + " " + person4.Age);*/

            int num = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < num; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ");
                Person person = new Person(cmd[0], int.Parse(cmd[1]));
                family.AddMember(person);
            }
            /*var oldest = family.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);*/

            foreach (var person in family.Members.Where(p=>p.Age >30).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");

            }
        }
    }
}
