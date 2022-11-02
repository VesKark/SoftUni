using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn" or "Winter"
            int fisher = int.Parse(Console.ReadLine()); //number of fishers

            // Calculating costs:
            double shipRent = 0;

            if (fisher <= 6)
            {
                switch (season)
                {
                    case "Spring": shipRent = 3000.00 * 0.90; break; //discount 10%
                    case "Summer":
                    case "Autumn": shipRent = 4200.00 * 0.90; break; //discount 10%
                    case "Winter": shipRent = 2600.00 * 0.90; break; //discount 10%
                }
            }
            else if (fisher <= 11)
            {
                switch (season)
                {
                    case "Spring": shipRent = 3000.00 * 0.85; break; //discount 15%
                    case "Summer":
                    case "Autumn": shipRent = 4200.00 * 0.85; break; //discount 15%
                    case "Winter": shipRent = 2600.00 * 0.85; break; //discount 15%
                }
            }
            else if (fisher >= 12)
            {
                switch (season)
                {
                    case "Spring": shipRent = 3000.00 * 0.75; break; //discount 25%
                    case "Summer":
                    case "Autumn": shipRent = 4200.00 * 0.75; break; //discount 25%
                    case "Winter": shipRent = 2600.00 * 0.75; break; //discount 25%
                }
            }

            if (fisher % 2 == 0 && season != "Autumn")
            {
                shipRent *= 0.95; //additional discount from 5%
            }

            // Output:
            if (budget >= shipRent)
            {
                Console.WriteLine($"Yes! You have {budget - shipRent:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipRent - budget:F2} leva.");
            }
        }
    }
}
