using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string dayType = Console.ReadLine(); //"Weekday", "Weekend" or "Holiday"
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            // Estimating ticket price:
            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday": ticketPrice = 12; break;
                    case "Weekend": ticketPrice = 15; break;
                    case "Holiday": ticketPrice = 5; break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday": ticketPrice = 18; break;
                    case "Weekend": ticketPrice = 20; break;
                    case "Holiday": ticketPrice = 12; break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday": ticketPrice = 12; break;
                    case "Weekend": ticketPrice = 15; break;
                    case "Holiday": ticketPrice = 10; break;
                }
            }

            // Output ticket price:
            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
