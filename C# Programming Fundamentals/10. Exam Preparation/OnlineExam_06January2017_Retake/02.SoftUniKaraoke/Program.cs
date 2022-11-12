using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] separator = new string[] { ", " };
        List<string> participants = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> availableSongs = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        SortedDictionary<string, List<string>> awardsPerParticipant = new SortedDictionary<string, List<string>>();
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "dawn")
        {
            string[] performance = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string participant = performance[0];
            string song = performance[1];
            string award = performance[2];

            if (participants.Contains(participant) && availableSongs.Contains(song))
            {
                if (!awardsPerParticipant.ContainsKey(participant))
                {
                    awardsPerParticipant.Add(participant, new List<string>());
                }

                if (!awardsPerParticipant[participant].Contains(award))
                {
                    awardsPerParticipant[participant].Add(award);
                }
            }
        }

        if (!awardsPerParticipant.Any())
        {
            Console.WriteLine("No awards");
            return;
        }

        foreach (var participant in awardsPerParticipant.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine("{0}: {1} awards", participant.Key, participant.Value.Count);

            foreach (string award in participant.Value.OrderBy(x => x))
            {
                Console.WriteLine("--{0}", award);
            }
        }
    }
}