using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static Dictionary<string, HashSet<string>> forceBook;
    static Dictionary<string, string> allUsers;
    private static void Main(string[] args)
    {
        forceBook = new Dictionary<string, HashSet<string>>(); //side -> Set of members
        allUsers = new Dictionary<string, string>(); //user -> side
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            string[] currUser = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.None);

            if (input.Contains(" | "))
            {
                string side = currUser[0];
                string user = currUser[1];

                if (allUsers.ContainsKey(user))
                {
                    continue;
                }
                
                AddUser(user, side);
            }            
            else if (input.Contains(" -> "))
            {
                string user = currUser[0];
                string side = currUser[1];

                if (allUsers.ContainsKey(user))
                {
                    string currSide = allUsers[user];
                    forceBook[currSide].Remove(user);
                }
                
                AddUser(user, side); //change user side                
                Console.WriteLine($"{user} joins the {side} side!");
            }
        }

        // print forcebook:
        foreach (var side in forceBook.OrderByDescending(user => user.Value.Count).ThenBy(user => user.Key))
        {
            if (side.Value.Count == 0)
            {
                break;
            }

            Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

            foreach (string user in side.Value.OrderBy(name => name))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }

    public static void AddUser(string user, string side)
    {
        if (!forceBook.ContainsKey(side))
        {
            forceBook[side] = new HashSet<string>();
        }

        forceBook[side].Add(user);
        allUsers[user] = side;
    }
}