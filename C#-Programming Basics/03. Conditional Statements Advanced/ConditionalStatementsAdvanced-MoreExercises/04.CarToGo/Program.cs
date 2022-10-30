using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Summer" or "Winter"

            // Estimating car price, type and class:
            string carClass = "";
            string carType = "";
            double carPrice = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";
                switch (season)
                {
                    case "Summer":
                        carPrice = 0.35 * budget;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        carPrice = 0.65 * budget;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        carPrice = 0.45 * budget;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        carPrice = 0.80 * budget;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carPrice = 0.90 * budget;
                carType = "Jeep";
            }

            // Output:
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:F2}");
        }
    }
}
