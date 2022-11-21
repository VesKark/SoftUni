using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        char charA = char.Parse(Console.ReadLine());
        char charB = char.Parse(Console.ReadLine());

        string text = Console.ReadLine();

        int sumOfChars = 0;

        foreach (char currChar in text)
        {
            if (currChar > charA && currChar < charB)
            {
                sumOfChars += currChar;
            }
        }

        Console.WriteLine(sumOfChars);
    }
}