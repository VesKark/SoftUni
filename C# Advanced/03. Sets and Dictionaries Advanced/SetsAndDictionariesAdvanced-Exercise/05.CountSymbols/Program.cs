using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<char, int> charOccurrences = new SortedDictionary<char, int>();
        string text = Console.ReadLine();

        foreach (char current in text)
        {
            if (!charOccurrences.ContainsKey(current))
            {
                charOccurrences.Add(current, 1);
            }
            else
            {
                charOccurrences[current]++;
            }
        }

        foreach (var currChar in charOccurrences)
        {
            Console.WriteLine($"{currChar.Key}: {currChar.Value} time/s");
        }
        
    }
}