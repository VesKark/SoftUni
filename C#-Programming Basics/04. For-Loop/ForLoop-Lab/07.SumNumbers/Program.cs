﻿using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int inputN = 0;

            for (int i = 0; i < n; i++)
            {
                inputN = int.Parse(Console.ReadLine());
                sum += inputN;                
            }

            Console.WriteLine(sum);
        }
    }
}
