using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        // create list with invitations and filter data structure:
        List<string> invitedPeople = Console.ReadLine().Split().ToList();
        HashSet<string> filters = new HashSet<string>();

        // save all needed filters:
        string command = Console.ReadLine();

        while (command != "Print")
        {
            string[] currCommand = command.Split(';');
            string action = currCommand[0];
            string filterAndParameter = currCommand[1] + ";" + currCommand[2];

            if (action == "Add filter")
            {
                filters.Add(filterAndParameter);
            }
            else if (action == "Remove filter")
            {
                filters.Remove(filterAndParameter);
            }

            command = Console.ReadLine();
        }

        // apply filters:
        foreach (string currFilter in filters)
        {
            string filterType = currFilter.Split(';')[0];
            string filterParameter = currFilter.Split(';')[1];

            Predicate<string> filter = ApplyFilter(filterType, filterParameter);
            invitedPeople.RemoveAll(filter);
        }

        // print lfiltered list:
        Console.WriteLine(string.Join(" ", invitedPeople));
    }

    private static Predicate<string> ApplyFilter(string filterType, string filterParameter)
    {
        if (filterType == "Starts with")
        {
            return name => name.StartsWith(filterParameter);
        }
        else if (filterType == "Ends with")
        {
            return name => name.EndsWith(filterParameter);
        }
        else if (filterType == "Length")
        {
            return name => name.Length == int.Parse(filterParameter);
        }
        else if (filterType == "Contains")
        {
            return name => name.Contains(filterParameter);
        }

        throw new NotImplementedException();
    }
}