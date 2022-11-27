using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string inputText = Console.ReadLine();
        string pattern = @"(\@|\#)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

        MatchCollection wordPairMatches = Regex.Matches(inputText, pattern);
        int wordPairsCount = wordPairMatches.Count;

        if (wordPairsCount == 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else
        {
            Console.WriteLine("{0} word pairs found!", wordPairsCount);
        }

        List<string> validWordPairs = new List<string>();

        foreach (Match wordPairMatch in wordPairMatches)
        {
            string firstWord = wordPairMatch.Groups["firstWord"].Value;
            string secondWord = wordPairMatch.Groups["secondWord"].Value;

            char[] charArray = secondWord.ToCharArray();
            Array.Reverse(charArray);
            string secondWordReversed = new string(charArray);

            if (firstWord == secondWordReversed)
            {
                string wordPair = firstWord + " <=> " + secondWord;
                validWordPairs.Add(wordPair);
            }
        }

        if (!validWordPairs.Any())
        {
            Console.WriteLine("No mirror words!");
        }
        else
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", validWordPairs));
        }
    }
}