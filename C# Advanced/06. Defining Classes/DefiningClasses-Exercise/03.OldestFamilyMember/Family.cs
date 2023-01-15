using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People { get; set; }

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            int ageOfOldestMember = People.Max(age => age.Age);
            return People.FirstOrDefault(p => p.Age == ageOfOldestMember);
        }
    }
}
