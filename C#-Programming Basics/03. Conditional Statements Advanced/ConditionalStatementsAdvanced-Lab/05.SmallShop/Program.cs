using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string product = Console.ReadLine(); //"coffee", "water", "beer", "sweets" of "peanuts"
            string city = Console.ReadLine(); //"Sofia", "Plovdiv" or "Varna"
            double quantity = double.Parse(Console.ReadLine()); //quantity of product

            double price = 0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee": price = 0.50 * quantity; break;
                    case "water": price = 0.80 * quantity; break;
                    case "beer": price = 1.20 * quantity; break;
                    case "sweets": price = 1.45 * quantity; break;
                    case "peanuts": price = 1.60 * quantity; break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = 0.40 * quantity; break;
                    case "water": price = 0.70 * quantity; break;
                    case "beer": price = 1.15 * quantity; break;
                    case "sweets": price = 1.30 * quantity; break;
                    case "peanuts": price = 1.50 * quantity; break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee": price = 0.45 * quantity; break;
                    case "water": price = 0.70 * quantity; break;
                    case "beer": price = 1.10 * quantity; break;
                    case "sweets": price = 1.35 * quantity; break;
                    case "peanuts": price = 1.55 * quantity; break;
                }
            }

            // Output - price:            
            Console.WriteLine(price);
        }
    }
}
