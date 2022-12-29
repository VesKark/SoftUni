using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int lengthSet1 = int.Parse(input.Split()[0]);
        int lengthSet2 = int.Parse(input.Split()[1]);

        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        for (int i = 0; i < lengthSet1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }
        List<int> set1Values = set1.ToList();

        for (int i = 0; i < lengthSet2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        set1.IntersectWith(set2);

        Console.WriteLine(string.Join(" ", set1));
    }
}