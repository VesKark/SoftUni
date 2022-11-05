using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> participants = new Dictionary<string, int>();
        string[] inputParticipants = Console.ReadLine().Split(", ");
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "end of race")
        {
            StringBuilder name = new StringBuilder();
            int distance = 0;

            foreach (char currChar in input)
            {
                if (char.IsLetter(currChar))
                {
                    name.Append(currChar);
                }
                else if (char.IsDigit(currChar))
                { 
                    distance += currChar - '0';
                }
            }

            if (inputParticipants.Contains(name.ToString()))
            {
                if (participants.ContainsKey(name.ToString()))
                {
                    participants[name.ToString()] += distance;
                }
                else
                {
                    participants[name.ToString()] = distance;
                }
            }
        }

        List<string> winners = participants.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

        Console.WriteLine($"1st place: {winners[0]}");
        Console.WriteLine($"2nd place: {winners[1]}");
        Console.WriteLine($"3rd place: {winners[2]}");
    }
}