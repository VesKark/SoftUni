using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> results = new Dictionary<string, int>();
        Dictionary<string, int> submissions = new Dictionary<string, int>();

        string input = string.Empty;

        // 1. input exam data:
        while ((input = Console.ReadLine()) != "exam finished")
        {
            string[] participant = input.Split('-');
            string username = participant[0];
            string language = participant[1];

            //check if user was banned from exam        
            if (participant.Length == 2)
            {
                if (results.ContainsKey(username))
                {
                    results.Remove(username);
                }
                continue;
            }
            
            // input user points from exam:
            int points = int.Parse(participant[2]);

            if (!results.ContainsKey(username))
            {
                results[username] = points;
            }
            else if (points > results[username])
            {
                results[username] = points;
            }

            if (!submissions.ContainsKey(language))
            {
                submissions[language] = 1;
            }
            else
            {
                submissions[language] += 1;
            }
        }

        // 2. print exam results:
        Console.WriteLine("Results:");
        PrintExamData(results, '|');

        // 3. print exam submissions:
        Console.WriteLine("Submissions:");
        PrintExamData(submissions, '-');
    }

    public static void PrintExamData(Dictionary<string, int> examData, char separator)
    {
        foreach (var user in examData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{user.Key} {separator} {user.Value}");
        }
    }
}