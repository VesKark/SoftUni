using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Summer" or "Winter"

            // Estimating location, price and accomodation type for the vacation:                      
            string accomodation = "";
            string location = "";
            double vacationPrice = 0;

            if (budget <= 1000)
            {
                accomodation = "Camp";
                switch (season)
                {
                    case "Summer":
                        vacationPrice = 0.65 * budget;
                        location = "Alaska";
                        break;
                    case "Winter":
                        vacationPrice = 0.45 * budget;
                        location = "Morocco";
                        break;
                }
            }
            else if (budget <= 3000)
            {
                accomodation = "Hut";
                switch (season)
                {
                    case "Summer":
                        vacationPrice = 0.80 * budget;
                        location = "Alaska";
                        break;
                    case "Winter":
                        vacationPrice = 0.60 * budget;
                        location = "Morocco";
                        break;
                }
            }
            else if (budget > 3000)
            {
                accomodation = "Hotel";
                vacationPrice = 0.90 * budget;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
            }

            // Output:
            Console.WriteLine($"{location} - {accomodation} - {vacationPrice:F2}");
        }
    }
}
