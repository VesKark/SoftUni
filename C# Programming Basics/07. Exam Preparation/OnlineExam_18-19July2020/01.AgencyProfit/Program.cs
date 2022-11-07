using System;

namespace _01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string aviocompany = Console.ReadLine();
            int ticketsAdults = int.Parse(Console.ReadLine());
            int ticketsKids = int.Parse(Console.ReadLine());
            double priceAdults = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());

            // Estimating ticket costs:
            double sumCosts = ticketsAdults * priceAdults + ticketsKids * priceAdults * 0.30;
            double sumCostsService = (ticketsAdults + ticketsKids) * serviceTax;

            // Estimating and printing company win:
            double win = (sumCosts + sumCostsService) * 0.20; // 20% of the total
            Console.WriteLine($"The profit of your agency from {aviocompany} tickets is {win:F2} lv.");
        }
    }
}
