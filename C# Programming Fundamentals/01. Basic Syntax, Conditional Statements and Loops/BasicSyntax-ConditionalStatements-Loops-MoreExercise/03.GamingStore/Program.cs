using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:            
            double currentBalance = double.Parse(Console.ReadLine());
            double startBalance = currentBalance;
            string gameName = Console.ReadLine();

            while (gameName != "Game Time")
            {
                double gamePrice = 0;
                switch (gameName)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default: Console.WriteLine("Not Found"); break;
                }

                if (currentBalance >= gamePrice && gamePrice != 0)
                {
                    Console.WriteLine($"Bought {gameName}");
                    currentBalance -= gamePrice;
                }
                else if (currentBalance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
               
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gameName = Console.ReadLine();
            }

            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${startBalance - currentBalance:F2}. Remaining: ${currentBalance:F2}");
            }
        }
    }
}
