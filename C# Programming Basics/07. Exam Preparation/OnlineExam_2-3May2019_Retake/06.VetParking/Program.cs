using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine()); //number of days
            int hours = int.Parse(Console.ReadLine()); //hours per day

            // Estimating parking costs:
            double costsPerDay = 0;
            double costsTotal = 0;

            for (int d = 1; d <= days; d++)
            {
                for (int h = 1; h <= hours; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        costsPerDay += 2.50;                        
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        costsPerDay += 1.25;
                    }
                    else
                    {
                        costsPerDay += 1.00;
                    }                    
                }

                Console.WriteLine($"Day: {d} - {costsPerDay:F2} leva");
                costsTotal += costsPerDay;
                costsPerDay = 0;
            }

            Console.WriteLine($"Total: {costsTotal:F2} leva");
        }
    }
}
