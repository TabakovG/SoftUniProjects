using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public string Name { get => this.name; private set => this.name = value; }

        public int Age { get => this.age; private set => this.age = value; }

        public string Birthdate { get => this.birthdate; set => this.birthdate = value; }

        public string Id { get => this.id; set => this.id = value; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
