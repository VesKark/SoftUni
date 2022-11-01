using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int magnolias = int.Parse(Console.ReadLine()); //number of magnolias
            int bluebells = int.Parse(Console.ReadLine()); //number of bluebells
            int roses = int.Parse(Console.ReadLine()); //number of roses
            int cactus = int.Parse(Console.ReadLine()); //number of cactus
            double giftPricce = double.Parse(Console.ReadLine()); //gift price [leva]

            /* Prices:
                magnolias = 3.25 leva
                bluebells = 4.00 leva
                roses = 3.50 leva
                cactus = 8.00 leva
            */

            // Calculating total price, incl. deducting of 5% VAT:
            double totalPrice = (magnolias * 3.25 + bluebells * 4.00 + roses * 3.50 + cactus * 8.00) * 0.95;

            // Output:
            if (totalPrice >= giftPricce)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalPrice - giftPricce)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPricce - totalPrice)} leva.");
            }
        }
    }
}
