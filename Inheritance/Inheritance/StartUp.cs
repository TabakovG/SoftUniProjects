using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine(new String('-', 20));

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Console.WriteLine(new String('-', 20));

            Dog dog2 = new Dog();
            dog2.Eat();
            dog2.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
