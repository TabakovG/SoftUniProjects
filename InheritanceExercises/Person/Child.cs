using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name)
        {
            if (age <= 15)
            { 
                this.Age = age;
            }
            else
            {
                throw new ArgumentException();
            }
        }
       /* public Child(string name, int age) : base(name, age)
        { 
        }*/

    }
}
