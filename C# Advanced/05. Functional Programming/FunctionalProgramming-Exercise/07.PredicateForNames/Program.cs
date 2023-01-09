using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();

        Predicate<string> validateNames = name => name.Length <= length;

        foreach (string name in names)
        {
            if (validateNames(name))
            {
                Console.WriteLine(name);
            }
        }
    }
}