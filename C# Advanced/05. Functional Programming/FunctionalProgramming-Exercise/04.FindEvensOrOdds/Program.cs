using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int start = boundaries[0];
        int end = boundaries[1];

        List<int> allValues = new List<int>();

        for (int i = start; i <= end; i++)
        {
            allValues.Add(i);
        }

        string type = Console.ReadLine();
        Predicate<int> evenOrOdd = null;

        if (type == "odd")
        {
            evenOrOdd = currValue => currValue % 2 != 0;
        }
        else if (type == "even")
        {
            evenOrOdd = currValue => currValue % 2 == 0;
        }

        Console.WriteLine(string.Join(" ", allValues.FindAll(evenOrOdd)));
    }
}