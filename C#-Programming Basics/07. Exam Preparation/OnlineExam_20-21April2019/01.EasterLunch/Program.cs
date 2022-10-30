using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int easterBreadCount = int.Parse(Console.ReadLine());
            int eggs12Count = int.Parse(Console.ReadLine()); //price of box with 12 eggs
            int biscuitsKg = int.Parse(Console.ReadLine()); //biscuits in kg

            // Estimating lunch costs:
            double lunchCosts = 3.20 * easterBreadCount + 4.35 * eggs12Count + 5.40 * biscuitsKg + 0.15 * 12 * eggs12Count;
            Console.WriteLine($"{lunchCosts:F2}");
        }
    }
}
