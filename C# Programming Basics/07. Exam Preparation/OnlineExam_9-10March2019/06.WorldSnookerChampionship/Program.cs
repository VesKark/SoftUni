using System;

namespace _06.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string tournirStage = Console.ReadLine(); //"Quarter final", "Semi final" or "Final"
            string ticketType = Console.ReadLine(); //"Standard", "Premium" или "VIP"
            int ticketCount = int.Parse(Console.ReadLine());
            bool trophyPicture = Console.ReadLine() == "Y"; //"Y" = TRUE, "N" = FALSE

            // Assigning ticket prices:
            double ticketPrice = 0;

            if (ticketType == "Standard")
            {
                switch (tournirStage)
                {
                    case "Quarter final": ticketPrice = 55.50; break;
                    case "Semi final": ticketPrice = 75.88; break;
                    case "Final": ticketPrice = 110.10; break;
                }
            }
            else if (ticketType == "Premium")
            {
                switch (tournirStage)
                {
                    case "Quarter final": ticketPrice = 105.20; break;
                    case "Semi final": ticketPrice = 125.22; break;
                    case "Final": ticketPrice = 160.66; break;
                }
            }
            else if (ticketType == "VIP")
            {
                switch (tournirStage)
                {
                    case "Quarter final": ticketPrice = 118.90; break;
                    case "Semi final": ticketPrice = 300.40; break;
                    case "Final": ticketPrice = 400.00; break;
                }
            }

            // Estimating total price:
            double totalCosts = ticketCount * ticketPrice;

            if (totalCosts > 2500 && totalCosts <= 4000)
            {
                totalCosts *= 0.90; //discount 10%
            }
            else if (totalCosts > 4000)
            {
                totalCosts *= 0.75; //discount 25%
                trophyPicture = false;
            }

            if (trophyPicture)
            {
                totalCosts += ticketCount * 40;
            }

            // Printing result:
            Console.WriteLine($"{totalCosts:F2}");
        }
    }
}
