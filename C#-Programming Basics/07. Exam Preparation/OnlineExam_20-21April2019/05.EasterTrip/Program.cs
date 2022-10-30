using System;

namespace _05.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string destination = Console.ReadLine(); //"France", "Italy" or "Germany"
            string tripDates = Console.ReadLine(); //"21-23", "24-27" or "28-31"
            int nights = int.Parse(Console.ReadLine());

            // Assigning prices per night:
            double pricePerNight = 0;

            if (destination == "France")
            {
                switch (tripDates)
                {
                    case "21-23": pricePerNight = 30; break;
                    case "24-27": pricePerNight = 35; break;
                    case "28-31": pricePerNight = 40; break;
                }
            }
            else if (destination == "Italy")
            {
                switch (tripDates)
                {
                    case "21-23": pricePerNight = 28; break;
                    case "24-27": pricePerNight = 32; break;
                    case "28-31": pricePerNight = 39; break;
                }
            }
            else if (destination == "Germany")
            {
                switch (tripDates)
                {
                    case "21-23": pricePerNight = 32; break;
                    case "24-27": pricePerNight = 37; break;
                    case "28-31": pricePerNight = 43; break;
                }
            }

            // Output trip price and destination:
            Console.WriteLine($"Easter trip to {destination} : {pricePerNight * nights:F2} leva.");
        }
    }
}
