using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder capitalLetters = new StringBuilder();
        List<string> wordCodes = new List<string>();

        string[] input = Console.ReadLine().Split('|');

        string patternCapitalLetters = @"([\#\$\%\*\&])([A-Z]{1,})\1";
        string patternWord = @"(\d{2})\:(\d{2})";

        MatchCollection matchCapitalLetters = Regex.Matches(input[0], patternCapitalLetters);
        MatchCollection matchWords = Regex.Matches(input[1], patternWord);
        string[] words = input[2].Split();

        foreach (Match match in matchCapitalLetters)
        {
            capitalLetters.Append(match.Groups[2].Value);
        }

        foreach (Match match in matchWords)
        {
            char asciiTableSign = (char)int.Parse(match.Groups[1].Value);

            if (!capitalLetters.ToString().Contains(asciiTableSign))
            {
                continue;
            }

            string wordCode = asciiTableSign + match.Groups[2].Value;

            if (!wordCodes.Contains(wordCode))
            {
                wordCodes.Add(wordCode);
            }
        }

        foreach (string word in words)
        {
            foreach (string code in wordCodes)
            {
                int codeLength = int.Parse(code.Substring(1));

                if (codeLength > 20)
                {
                    continue;
                }

                if (word[0] == code[0] && word.Length == codeLength + 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}