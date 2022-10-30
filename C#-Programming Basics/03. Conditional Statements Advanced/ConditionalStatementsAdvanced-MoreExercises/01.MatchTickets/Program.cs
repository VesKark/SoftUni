using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            bool ticket = Console.ReadLine() == "Normal"; //True if "Normal", False if "VIP"
            int people = int.Parse(Console.ReadLine());

            // Estimating costs for transport:
            double transport = 0;

            if (people <= 4)
            {
                transport = budget * 0.75; // 75% of budget
            }
            else if (people <= 9)
            {
                transport = budget * 0.60; // 60% of budget
            }
            else if (people <= 24)
            {
                transport = budget * 0.50; // 50% of budget
            }
            else if (people <= 49)
            {
                transport = budget * 0.40; // 40% of budget
            }
            else if (people > 50)
            {
                transport = budget * 0.25; // 25% of budget
            }

            // Estimating costs for match tickets:
            double ticketCosts = 0;

            if (ticket)
            {
                ticketCosts = 249.99 * people;
            }
            else
            {
                ticketCosts = 499.99 * people;
            }

            // Output:
            double totalCosts = transport + ticketCosts;

            if (budget >= totalCosts)
            {
                Console.WriteLine($"Yes! You have {budget - totalCosts:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCosts - budget:F2} leva.");
            }
        }
    }
}
