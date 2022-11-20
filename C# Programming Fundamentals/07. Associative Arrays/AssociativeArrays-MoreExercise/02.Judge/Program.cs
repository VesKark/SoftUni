internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> submData = new Dictionary<string, Dictionary<string, int>>();

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "no more time")
        {
            string[] submission = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string username = submission[0];
            string contest = submission[1];
            int points = int.Parse(submission[2]);

            if (!submData.ContainsKey(contest))
            {
                submData[contest] = new Dictionary<string, int>() { { username, points } };
            }
            else if (!submData[contest].ContainsKey(username))
            {
                submData[contest][username] = points;
            }
            else if (submData[contest][username] < points)
            {
                submData[contest][username] = points;
            }
        }

        Dictionary<string, int> userData = new Dictionary<string, int>();
        int counter;

        foreach (var contest in submData)
        {
            Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
            counter = 1;

            foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {                
                Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                counter++;

                if (!userData.ContainsKey(user.Key))
                {
                    userData[user.Key] = user.Value;
                }
                else
                {
                    userData[user.Key] += user.Value;
                }
            }
        }

        Console.WriteLine("Individual standings:");
        counter = 1;

        foreach (var user in userData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{counter}. {user.Key} -> {user.Value}");
            counter++;
        }
    }
}