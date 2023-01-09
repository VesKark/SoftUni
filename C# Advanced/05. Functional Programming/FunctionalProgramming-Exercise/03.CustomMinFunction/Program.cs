using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Func<int[], int> findMinValue = numbers => numbers.Min();
        Console.WriteLine(findMinValue(numbers));
    }
}