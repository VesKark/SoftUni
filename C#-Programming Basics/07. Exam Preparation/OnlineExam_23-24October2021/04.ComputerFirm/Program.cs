using System;

namespace _04.ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int computers = int.Parse(Console.ReadLine()); //count of computers

            // Estimating computer rating and sales:
            double madeSales = 0;
            int sumRatings = 0;

            for (int i = 0; i < computers; i++)
            {
                int computerPoints = int.Parse(Console.ReadLine());
                int computerRating = computerPoints % 10;
                int possibleSales = computerPoints / 10;
                sumRatings += computerRating;

                switch (computerRating)
                { 
                    case 3: madeSales += 0.50 * possibleSales; break;
                    case 4: madeSales += 0.70 * possibleSales; break;
                    case 5: madeSales += 0.85 * possibleSales; break;
                    case 6: madeSales += 1.00 * possibleSales; break;
                }
            }

            // Output:
            Console.WriteLine($"{madeSales:F2}");
            Console.WriteLine($"{sumRatings * 1.00 / computers:F2}");
        }
    }
}
