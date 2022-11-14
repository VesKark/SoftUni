﻿using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array and magic numbers:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            // Finding numbers in array building MagicSum:
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == magicSum)
                    {
                        Console.WriteLine(array[i] + " " + array[j]);
                    }
                }
            }
        }
    }
}
