﻿using System;

namespace _08.DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
