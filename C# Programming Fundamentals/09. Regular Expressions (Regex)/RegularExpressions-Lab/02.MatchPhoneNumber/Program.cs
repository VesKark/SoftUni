using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> phoneNr = new List<string>();
        string inputPhoneNr = Console.ReadLine();
        string phonePattern = @"\+359(\s|\-)2\1\d{3}\1\d{4}\b";

        MatchCollection phoneMatches = Regex.Matches(inputPhoneNr, phonePattern);

        foreach (Match match in phoneMatches)
        {
            phoneNr.Add(match.Value);
        }

        Console.WriteLine(String.Join(", ", phoneNr));
    }
}