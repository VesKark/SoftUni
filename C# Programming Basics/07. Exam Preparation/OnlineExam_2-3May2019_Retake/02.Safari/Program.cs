using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine()); //fuel in Liter (price = 2.10 lv/L)
            string day = Console.ReadLine(); //"Saturday" or "Sunday"

            // Estimating total costs for the safari:
            double totalCosts = fuel * 2.10 + 100.00; //safari guide costs 100 leva

            if (day == "Saturday")
            {
                totalCosts *= 0.90; //discount 10%
            }
            else if (day == "Sunday")
            {
                totalCosts *= 0.80; //discount 20%
            }

            // Output:
            if (budget >= totalCosts)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalCosts:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalCosts - budget:F2} lv.");
            }
        }
    }
}
