using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Dictionary<double, int> counts = new Dictionary<double, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            double currNumber = numbers[i];

            if (!counts.ContainsKey(currNumber))
            {
                counts[currNumber] = 1;
            }
            else
            {
                counts[currNumber] += 1;
            }
        }

        foreach (var number in counts)
        {
            Console.WriteLine($"{number.Key} - {number.Value} times");
        }
    }
}