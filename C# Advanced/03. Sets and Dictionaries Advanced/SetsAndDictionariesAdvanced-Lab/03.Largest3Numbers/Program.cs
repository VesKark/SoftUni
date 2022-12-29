using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();
        Console.WriteLine(string.Join(" ", numbers));
    }
}