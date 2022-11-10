using System.Text.RegularExpressions;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputData = Console.ReadLine().ToUpper();
        string pattern = @"(\D+)(\d+)";
        List<char> allChars = new List<char>();

        MatchCollection matches = Regex.Matches(inputData, pattern);
        StringBuilder result = new StringBuilder();

        foreach (Match match in matches)
        {
            string text = match.Groups[1].Value;
            int number = int.Parse(match.Groups[2].Value);

            for (int i = 0; i < number; i++)
            {
                result.Append(text);
            }
        }

        int count = result.ToString().Distinct().Count();

        Console.WriteLine("Unique symbols used: {0}", count);
        Console.WriteLine(result.ToString());
    }
}