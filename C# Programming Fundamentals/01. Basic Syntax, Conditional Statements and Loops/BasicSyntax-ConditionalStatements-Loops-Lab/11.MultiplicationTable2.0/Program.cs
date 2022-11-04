using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            // Output multiplication table for num:
            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
        }
    }
}
