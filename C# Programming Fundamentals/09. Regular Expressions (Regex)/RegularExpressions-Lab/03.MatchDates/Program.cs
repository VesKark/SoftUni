using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputData = Console.ReadLine();        
        
        string dataPattern = @"(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

        MatchCollection dataMatches = Regex.Matches(inputData, dataPattern);

        foreach (Match match in dataMatches)
        {
            string day = match.Groups["day"].Value;
            string month = match.Groups["month"].Value;
            string year = match.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}