using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int rangeEnd = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> validNumbers = new List<int>();

        for (int i = 1; i <= rangeEnd; i++)
        {
            Predicate<int[]> isDivisible = numbers => numbers.Any(x => i % x != 0);

            if (!isDivisible(numbers))
            {
                validNumbers.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", validNumbers));
    }
}