namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string anmlType = Console.ReadLine();
            while (anmlType != "Beast!")
            {

                try
                {

                    string[] animalInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);

                    Animal animal = null;

                    if (anmlType == "Dog")
                    {
                        string gender = animalInfo[2];

                        animal = new Dog(name, age, gender);
                    }
                    else if (anmlType == "Cat")
                    {
                        string gender = animalInfo[2];
                        var newCat = new Cat(name, age, gender);
                        animal = newCat;
                    }
                    else if (anmlType == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (anmlType == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Type");
                    }
                    animals.Add(animal);

                    anmlType = Console.ReadLine();
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }

            }

            foreach (var anml in animals)
            {
                Console.WriteLine(anml);
            }
        }
    }
}
