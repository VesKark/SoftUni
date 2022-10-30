using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double movieBudget = double.Parse(Console.ReadLine());
            int backgroundActors = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            // Discount for clothing:
            if (backgroundActors > 150)
            {
                clothingPrice = clothingPrice * 0.9; //discount 10%
            }

            // Prices:
            double decorPrice = movieBudget * 0.1; 
            double moneyTotal = backgroundActors * clothingPrice + decorPrice;

            // Output:
            if (moneyTotal > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyTotal - movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - moneyTotal:F2} leva left.");
            }
        }
    }
}
