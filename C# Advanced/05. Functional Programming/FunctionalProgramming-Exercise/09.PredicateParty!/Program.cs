using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

internal class Program
{
    static List<string> people = new List<string>();
    private static void Main(string[] args)
    {
        // create people list and functions:
        people = Console.ReadLine().Split().ToList();

        Func<string, List<string>> startsWith = name => people.FindAll(x => x.StartsWith(name));
        Func<string, List<string>> endsWith = name => people.FindAll(x => x.EndsWith(name));
        Func<int, List<string>> matchingLength = nameLength => people.FindAll(x => x.Length == nameLength);

        // manipulate people list:
        string command = Console.ReadLine();

        while (command != "Party!")
        {
            string[] currCommand = command.Split();
            string action = currCommand[0];
            string condition = currCommand[1];
            string personData = currCommand[2];

            if (condition == "StartsWith")
            {
                ExecuteAction(action, startsWith(personData));
            }
            else if (condition == "EndsWith")
            {
                ExecuteAction(action, endsWith(personData));
            }
            else if (condition == "Length")
            {
                int nameLength = int.Parse(personData);
                ExecuteAction(action, matchingLength(nameLength));
            }            

            command = Console.ReadLine();
        }

        // output people list:
        if (!people.Any())
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
        }
    }

    private static void ExecuteAction(string action, List<string> names)
    {
        if (action == "Double")
        {
            Double(names);
        }
        else if (action == "Remove")
        {
            Remove(names);
        }
    }

    static void Double(List<string> names)
    {
        for (int i = 0; i < people.Count; i++)
        {
            if (names.Contains(people[i]))
            {
                people.Insert(i, people[i]);
                i++;
            }
        }
    }

    static void Remove(List<string> names)
    {
        foreach (string name in names)
        {
            people.Remove(name);
        }
    }
}