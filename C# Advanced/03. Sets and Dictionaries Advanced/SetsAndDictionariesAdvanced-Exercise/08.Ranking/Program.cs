using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1) input contests:
        Dictionary<string, string> contestAccess = new Dictionary<string, string>();
        string input = Console.ReadLine();

        while (input != "end of contests")
        {
            string[] contestInfo = input.Split(':');
            string contestName = contestInfo[0];
            string contestPassword = contestInfo[1];

            contestAccess[contestName] = contestPassword;

            input = Console.ReadLine();
        }

        // 2) input submissions:
        SortedDictionary<string, Dictionary<string, int>> rankingInfo = new SortedDictionary<string, Dictionary<string, int>>();
        input = Console.ReadLine();

        while (input != "end of submissions")
        {
            string[] submissionInfo = input.Split("=>").ToArray();
            string contestName = submissionInfo[0];
            string contestPassword = submissionInfo[1];
            string userName = submissionInfo[2];
            int userPoints = int.Parse(submissionInfo[3]);

            if (!contestAccess.ContainsKey(contestName) || contestAccess[contestName] != contestPassword)
            {
                input = Console.ReadLine();
                continue;
            }

            Dictionary<string, int> contestResults = new Dictionary<string, int>();
            contestResults[contestName] = userPoints;

            if (!rankingInfo.ContainsKey(userName))
            {
                rankingInfo[userName] = contestResults;
            }
            else if (!rankingInfo[userName].ContainsKey(contestName))
            {
                rankingInfo[userName].Add(contestName, userPoints);
            }
            else if (rankingInfo[userName][contestName] < userPoints)
            {
                rankingInfo[userName][contestName] = userPoints;
            }

            input = Console.ReadLine();
        }

        // 3) find best candidate:
        string bestCandidate = string.Empty;
        int totalPoints = 0;

        foreach (var user in rankingInfo)
        {
            int pointsSum = user.Value.Values.Sum();
            if (pointsSum > totalPoints)
            {
                bestCandidate = user.Key;
                totalPoints = pointsSum;
            }
        }

        // 4) print results:
        Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
        Console.WriteLine("Ranking:");

        foreach (var user in rankingInfo)
        {
            Console.WriteLine(user.Key);

            foreach (var contest in user.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
}