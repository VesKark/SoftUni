using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedSet<string> chemicalCompounds = new SortedSet<string>();
        int inputCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputCount; i++)
        {
            string[] inputChemicalCompound = Console.ReadLine().Split();

            for (int j = 0; j < inputChemicalCompound.Length; j++)
            {
                chemicalCompounds.Add(inputChemicalCompound[j]);
            }
        }

        Console.WriteLine(string.Join(" ", chemicalCompounds));
    }
}