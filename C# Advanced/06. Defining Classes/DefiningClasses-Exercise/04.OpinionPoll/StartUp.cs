using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            int countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                string[] currPerson = Console.ReadLine().Split();
                string name = currPerson[0];
                int age = int.Parse(currPerson[1]);

                peopleList.Add(new Person(name, age));
            }

            foreach (Person person in peopleList.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
