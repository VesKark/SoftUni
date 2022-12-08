using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        // estimate cool threshold:
        string digitPattern = @"(\d)";
        MatchCollection digits = Regex.Matches(input, digitPattern);

        BigInteger coolThreshold = new BigInteger();
        coolThreshold = 1;

        foreach (Match digit in digits)
        {
            coolThreshold *= int.Parse(digit.Value);
        }

        // gather emojis:
        string emojiPattern = @"(\*{2}|\:{2})(?<emoji>[A-Z][a-z]{2,})\1";
        MatchCollection emojis = Regex.Matches(input, emojiPattern);

        List<string> allCoolEmojis = new List<string>();

        foreach (Match emoji in emojis)
        {
            string emojiName = emoji.Groups["emoji"].Value;

            int sum = emojiName.ToCharArray().Select(x => (int)x).Sum();

            if (sum >= coolThreshold)
            {
                allCoolEmojis.Add(emoji.Value);
            }
        }

        // print result:
        Console.WriteLine("Cool threshold: {0}", coolThreshold);
        Console.WriteLine("{0} emojis found in the text. The cool ones are:", emojis.Count);

        foreach (string coolEmoji in allCoolEmojis)
        {
            Console.WriteLine(coolEmoji);
        }
    }
}