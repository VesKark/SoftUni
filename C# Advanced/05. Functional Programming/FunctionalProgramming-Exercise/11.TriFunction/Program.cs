using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();

        Console.WriteLine(names.First(name => name.Select(x => (int)x).Sum() >= number));
    }
}