using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputPerson = input.Split();
                Person currPerson = new Person(inputPerson[0], inputPerson[1], int.Parse(inputPerson[2])); 
                allPeople.Add(currPerson);
            }

            allPeople = allPeople.OrderBy(x => x.Age).ToList();

            foreach (Person person in allPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
