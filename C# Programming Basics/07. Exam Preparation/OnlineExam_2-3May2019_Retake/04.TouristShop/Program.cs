using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            double productPrice = 0;
            int countProducts = 0;
            double sum = 0;

            while (product != "Stop")
            {
                productPrice = double.Parse(Console.ReadLine());
                countProducts++;

                if (countProducts % 3 == 0)
                {
                    productPrice *= 0.50;
                }

                sum += productPrice;

                if (sum > budget)
                {
                    break;
                }

                product = Console.ReadLine();
            }

            // Output:

            if (product == "Stop")
            {
                Console.WriteLine($"You bought {countProducts} products for {sum:F2} leva.");
            }
            else if (sum > budget)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {sum - budget:F2} leva!");
            }
        }
    }
}
