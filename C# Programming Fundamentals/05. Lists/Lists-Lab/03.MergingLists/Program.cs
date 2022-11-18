using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listMerged = new List<int>();

			int maxLength = Math.Max(listOne.Count, listTwo.Count);

			for (int i = 0; i < maxLength; i++)
			{
				if (i < listOne.Count)
				{
					listMerged.Add(listOne[i]);
				}
				if (i < listTwo.Count)
				{
					listMerged.Add(listTwo[i]);
				}
			}

			Console.WriteLine(string.Join(" ", listMerged));
		}
    }
}
