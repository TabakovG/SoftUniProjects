using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo( Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Name.CompareTo(other.Name);
        }
       /* public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return this.Name == other.Name && this.Age == other.Age;
        }*/

        public override int GetHashCode() => Name.GetHashCode()^Age.GetHashCode();

        
        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }
        public bool Equals( Person other)
        {
            return this.Name == other.Name && this.Age == other.Age;
        }
    }
}
