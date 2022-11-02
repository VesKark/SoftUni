using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string season = Console.ReadLine(); //"Spring", "Summer"; "Autumn" or "Winter"
            double kmMonth = double.Parse(Console.ReadLine()); //distance [km] in month

            // Estimating seasonal payment of the trucker (!!! one season has 4 months):
            double payment = 0;

            if (kmMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        payment = 4 * kmMonth * 0.75;
                        break;
                    case "Summer":
                        payment = 4 * kmMonth * 0.90;
                        break;
                    case "Winter":
                        payment = 4 * kmMonth * 1.05;
                        break;
                }
            }
            else if (kmMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        payment = 4 * kmMonth * 0.95;
                        break;
                    case "Summer":
                        payment = 4 * kmMonth * 1.10;
                        break;
                    case "Winter":
                        payment = 4 * kmMonth * 1.25;
                        break;
                }
            }
            else if (kmMonth <= 20000)
            {
                payment = 4 * kmMonth * 1.45;
            }

            // Output:
            payment *= 0.90; //charging 10% for taxes
            Console.WriteLine($"{payment:F2}");
        }
    }
}
