using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Func<string, bool> uppercaseWord = word => char.IsUpper(word[0]);

        Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Where(uppercaseWord)
            .ToList()
            .ForEach(word => Console.WriteLine(word));
    }
}