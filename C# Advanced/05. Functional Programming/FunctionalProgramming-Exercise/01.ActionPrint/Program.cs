using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> strings = Console.ReadLine().Split().ToList();
        Action<string> print = currString => Console.WriteLine(currString);
        strings.ForEach(print);
    }
}