using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            names.Add(Console.ReadLine());
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}