using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;


        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }
        public Person GetOldestMember()
        {
            if (Members.Count > 0)
            {
                int maxAge = this.Members.Select(x => x.Age).Max();
                return this.Members.Where(p => p.Age == maxAge).FirstOrDefault();
            }
            return null;
        }

    }
}
