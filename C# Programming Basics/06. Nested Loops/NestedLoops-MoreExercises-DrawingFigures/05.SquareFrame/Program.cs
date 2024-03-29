﻿using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Row 1:
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            // Rows 2 to N-1:
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            // Row N:
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
        }
    }
}
