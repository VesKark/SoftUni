﻿using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two arrays:
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Compare arrays:
            int sum = 0;
            bool areIdentical = true;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areIdentical = false;
                    break;
                }
                else
                {
                    sum += arrayOne[i];
                }
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
