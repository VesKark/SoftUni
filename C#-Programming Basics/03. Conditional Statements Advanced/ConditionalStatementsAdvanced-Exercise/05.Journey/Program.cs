using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"summer" or "winter"

            // Journey destination, type and costs:
            string destination = "";
            string type = "";
            double tripCosts = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        tripCosts = 0.30 * budget;
                        type = "Camp";
                        break;
                    case "winter":
                        tripCosts = 0.70 * budget;
                        type = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer": 
                        tripCosts = 0.40 * budget;
                        type = "Camp";
                        break;
                    case "winter":
                        tripCosts = 0.80 * budget;
                        type = "Hotel";
                        break;
                }
            }
            else if (budget <= 5000)
            {
                destination = "Europe";
                tripCosts = 0.90 * budget;
                type = "Hotel";
            }
                        
            // Output:
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {tripCosts:F2}");
        }
    }
}
