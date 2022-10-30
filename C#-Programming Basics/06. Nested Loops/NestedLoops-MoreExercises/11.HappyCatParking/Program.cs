using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            // Output:
            double sum = 0;
            double sumPerDay = 0;

            for (int d = 1; d <= days; d++)
            {
                for (int h = 1; h <= hours; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        sumPerDay += 2.50;
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        sumPerDay += 1.25;
                    }
                    else
                    {
                        sumPerDay += 1.00;
                    }
                }
                sum += sumPerDay;
                Console.WriteLine($"Day: {d} - {sumPerDay:F2} leva");
                sumPerDay = 0;
            }

            Console.WriteLine($"Total: {sum:F2} leva");
        }
    }
}
