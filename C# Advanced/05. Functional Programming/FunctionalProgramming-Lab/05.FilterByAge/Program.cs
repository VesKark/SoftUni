using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static List<Person> people = new List<Person>();

    private static void Main(string[] args)
    {
        // 1. read and save person data:
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string personData = Console.ReadLine();
            string name = personData.Split(", ")[0];
            int age = int.Parse(personData.Split(", ")[1]);

            Person currPerson = new Person(name, age);
            people.Add(currPerson);
        }

        // 2. read and set conditions (younder / older / value):
        string conditionType = Console.ReadLine();
        int conditionValue = int.Parse(Console.ReadLine());
        Predicate<Person> filter = CreateFilter(conditionType, conditionValue);

        // 3. create printer format:
        string format = Console.ReadLine();
        Func<Person, string> printer = CreatePrinter(format);

        // 4. print filtered result:
        PrintFilteredPeople(filter, printer);
    }

    private static void PrintFilteredPeople(Predicate<Person> filter, Func<Person, string> printer)
    {
        foreach (Person person in people)
        {
            if (filter(person))
            {
                Console.WriteLine(printer(person));
            }
        }
    }

    private static Func<Person, string> CreatePrinter(string format)
    {
        if (format == "name")
        {
            return person => person.Name;
        }
        else if (format == "age")
        {
            return person => person.Age.ToString();
        }
        return person => person.Name + " - " + person.Age.ToString();
    }   

    private static Predicate<Person> CreateFilter(string conditionType, int conditionValue)
    {
        if (conditionType == "younger")
        {
            return person => person.Age < conditionValue;
        }
        else if (conditionType == "older")
        {
            return person => person.Age >= conditionValue;
        }
        throw new NotImplementedException();
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