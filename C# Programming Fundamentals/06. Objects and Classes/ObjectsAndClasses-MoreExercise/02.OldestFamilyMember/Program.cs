using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            Family fullFamily = new Family();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] inputPerson = Console.ReadLine().Split();
                string name = inputPerson[0];
                int age = int.Parse(inputPerson[1]);

                Person currPerson = new Person(name, age);
                fullFamily.AddPerson(currPerson);
            }

            Person oldestMember = fullFamily.OldestFamilyMember();
            Console.WriteLine(oldestMember.Name + " " + oldestMember.Age);
        }
    }

    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddPerson(Person member)
        { 
            People.Add(member);
        }

        public Person OldestFamilyMember()
        {
            People = People.OrderByDescending(x => x.Age).ToList();
            return People[0];
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
