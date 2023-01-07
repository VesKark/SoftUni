using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        Action<int> print = result => Console.WriteLine(result);

        print(numbers.Count());
        print(numbers.Sum());
    }
}