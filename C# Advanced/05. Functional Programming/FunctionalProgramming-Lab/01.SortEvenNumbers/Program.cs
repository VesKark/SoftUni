using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Predicate<int> evenNum = x => x % 2 == 0;

        int[] numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .Where(x => evenNum(x))
            .OrderBy(x => x)
            .ToArray();

        Console.WriteLine(string.Join(", ", numbers));
    }
}