﻿using System;

namespace _02.RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
