using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputNames = Console.ReadLine();
        string namePattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        MatchCollection matchingNames = Regex.Matches(inputNames, namePattern);

        foreach (Match match in matchingNames)
        {
            Console.Write(match.Value + " ");
        }
    }
}