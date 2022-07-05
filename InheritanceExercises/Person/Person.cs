using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int _age;
        private string _name;

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value > 0 )
                {
                _age = value; 
                }
                else
                {
                    throw new ArgumentException();
                }
            
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
