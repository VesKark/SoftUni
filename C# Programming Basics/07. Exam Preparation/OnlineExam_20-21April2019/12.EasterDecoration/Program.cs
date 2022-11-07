using System;

namespace _12.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countClients = int.Parse(Console.ReadLine());

            // Selling easter decoration:
            double clientCosts = 0;
            double totalCosts = 0;
            int countProducts = 0;

            for (int i = 0; i < countClients; i++)
            {
                string product = Console.ReadLine(); //"basket", "wreath" or "chocolate bunny"

                while (product != "Finish")
                {
                    switch (product)
                    {
                        case "basket": clientCosts += 1.50; countProducts++; break;
                        case "wreath": clientCosts += 3.80; countProducts++; break;
                        case "chocolate bunny": clientCosts += 7.00; countProducts++; break;
                    }                    
                    product = Console.ReadLine();
                }

                if (countProducts % 2 == 0)
                {
                    clientCosts *= 0.80; //discount from 20%
                }
                totalCosts += clientCosts;                
                Console.WriteLine($"You purchased {countProducts} items for {clientCosts:F2} leva.");

                clientCosts = 0;
                countProducts = 0;
            }

            // Output average sellings:
            Console.WriteLine($"Average bill per client is: {totalCosts / countClients:F2} leva.");
        }
    }
}
