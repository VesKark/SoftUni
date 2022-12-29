using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> following = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();
        List<string> vloggers = new List<string>();

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Statistics")
        {
            string[] inputFollower = input.Split();
            string vloggerName = inputFollower[0];
            string action = inputFollower[1];

            if (action == "joined" && !vloggers.Contains(vloggerName))
            {
                vloggers.Add(vloggerName);
            }
            else if (action == "followed" && vloggers.Contains(vloggerName))
            {
                string followedVlogger = inputFollower[2];

                if (vloggerName == followedVlogger || !vloggers.Contains(followedVlogger))
                {
                    continue;
                }

                // 1) add Following:
                if (!following.ContainsKey(vloggerName))
                {
                    following[vloggerName] = new HashSet<string>();                    
                }
                following[vloggerName].Add(followedVlogger);

                // 2) add Follower:
                if (!followers.ContainsKey(followedVlogger))
                {
                    followers[followedVlogger] = new HashSet<string>();
                }
                followers[followedVlogger].Add(vloggerName);
            }
        }
        
        // sort vloggers data per count:
        Dictionary<string, Vlogger> vloggersData = new Dictionary<string, Vlogger>();

        foreach (string vlogger in vloggers)
        {
            int currFollowers = 0;
            if (followers.ContainsKey(vlogger))
            {
                currFollowers = followers[vlogger].Count;
            }
            
            int currFollowing = 0;
            if (following.ContainsKey(vlogger))
            {
                currFollowing = following[vlogger].Count;
            }

            Vlogger currVlogger = new Vlogger(currFollowers, currFollowing);
            vloggersData[vlogger] = currVlogger;
        }

        // print all vlogger data:
        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        vloggersData = vloggersData.OrderByDescending(x => x.Value.Followers).ThenBy(x => x.Value.Following).ToDictionary(x => x.Key, x => x.Value);

        int counter = 1;
        foreach (var vlogger in vloggersData)
        {
            Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Followers} followers, {vlogger.Value.Following} following");

            if (counter == 1)
            {
                foreach (string follower in followers[vlogger.Key].OrderBy(x => x))
                {
                    Console.WriteLine("*  " + follower);
                }
            }
            counter++;
        }
    }

    class Vlogger
    {
        public Vlogger (int followers, int following)
        {
            Followers = followers;
            Following = following;
        }

        public int Followers { get; set; }
        public int Following { get; set; }
    }
}