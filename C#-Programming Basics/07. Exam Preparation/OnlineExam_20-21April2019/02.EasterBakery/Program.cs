using System;

namespace _02.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsPackage = int.Parse(Console.ReadLine());
            int yeastPackage = int.Parse(Console.ReadLine());

            // Estimating costs for easter products:
            double sugarPrice = 0.75 * flourPrice;
            double eggsPackagePrice = 1.10 * flourPrice;
            double yeastPackagePrice = 0.20 * sugarPrice;

            // Output total costs:
            double totalCosts = flourKg * flourPrice + sugarKg * sugarPrice + eggsPackage * eggsPackagePrice + yeastPackage * yeastPackagePrice;
            Console.WriteLine($"{totalCosts:F2}");
        }
    }
}
