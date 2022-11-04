using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and sum coins in vending machine:
            string inputCoin = Console.ReadLine();
            double sumCoins = 0;

            while (inputCoin != "Start")
            {
                double coin = double.Parse(inputCoin);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sumCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                inputCoin = Console.ReadLine();
            }

            // Purchasing of products:
            string product = Console.ReadLine();
            bool noPurchase = false;

            while (product != "End")
            {
                double productPrice = 0;
                switch (product)
                {
                    case "Nuts": productPrice = 2.00; break;
                    case "Water": productPrice = 0.70; break;
                    case "Crisps": productPrice = 1.50; break;
                    case "Soda": productPrice = 0.80; break;
                    case "Coke": productPrice = 1.00; break;
                    default: noPurchase = true;  break;
                }

                if (productPrice > sumCoins)
                {
                    Console.WriteLine("Sorry, not enough money");
                    product = Console.ReadLine();
                    continue;
                }
                else
                {
                    sumCoins -= productPrice;
                }

                if (!noPurchase)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            // Left money:
            Console.WriteLine($"Change: {sumCoins:F2}");
        }
    }
}
