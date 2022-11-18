using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int length = Math.Min(listOne.Count, listTwo.Count);

            // mix lists:
            for (int i = 0; i < length; i++)
            {
                result.Add(listOne[i]);
                result.Add(listTwo[listTwo.Count - 1 - i]);
            }

            // set range:
            int rangeStart = 0;
            int rangeEnd = 0;

            if (listOne.Count > listTwo.Count)
            {
                rangeStart = listOne[listOne.Count - 2];
                rangeEnd = listOne[listOne.Count - 1];
            }
            else
            {
                rangeStart = listTwo[0];
                rangeEnd = listTwo[1];
            }

            if (rangeStart > rangeEnd)
            {
                int temp = rangeStart;
                rangeStart = rangeEnd;
                rangeEnd = temp;
            }

            // result list set in range:
            List<int> listInRange = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > rangeStart && result[i] < rangeEnd)
                {
                    listInRange.Add(result[i]);
                }
            }

            // print sorted result:
            listInRange.Sort();
            Console.WriteLine(string.Join(" ", listInRange));
        }
    }
}
