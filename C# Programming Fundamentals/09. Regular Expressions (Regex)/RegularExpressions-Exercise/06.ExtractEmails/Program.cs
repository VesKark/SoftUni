using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\s([^\.\-_][A-Za-z0-9\.\-_]+[A-Za-z]+)\@([^\.\-_][A-Za-z\.\-]+[A-Za-z]+)(\.[A-Za-z]+)";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            string user = match.Groups[1].Value;
            string hostName = match.Groups[2].Value;
            string hostEnding = match.Groups[3].Value;
            Console.WriteLine(user + "@" + hostName + hostEnding);
        }
    }
}