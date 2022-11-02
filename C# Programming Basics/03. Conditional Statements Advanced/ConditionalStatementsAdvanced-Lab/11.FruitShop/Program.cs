using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool weekday = dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday";
            bool weekend = dayOfWeek == "Saturday" || dayOfWeek == "Sunday";

            double purchasePrice = 0;

            // Output - price of purchase:
            if (weekday)
            {
                switch (fruit)
                {
                    case "banana": purchasePrice = 2.50 * quantity; break;
                    case "apple": purchasePrice = 1.20 * quantity; break;
                    case "orange": purchasePrice = 0.85 * quantity; break;
                    case "grapefruit": purchasePrice = 1.45 * quantity; break;
                    case "kiwi": purchasePrice = 2.70 * quantity; break;
                    case "pineapple": purchasePrice = 5.50 * quantity; break;
                    case "grapes": purchasePrice = 3.85 * quantity; break;
                    default: Console.WriteLine("error"); break;
                }
                if (purchasePrice != 0)
                {
                    Console.WriteLine($"{purchasePrice:F2}");
                }                
            }
            else if (weekend)
            {
                switch (fruit)
                {
                    case "banana": purchasePrice = 2.70 * quantity; break;
                    case "apple": purchasePrice = 1.25 * quantity; break;
                    case "orange": purchasePrice = 0.90 * quantity; break;
                    case "grapefruit": purchasePrice = 1.60 * quantity; break;
                    case "kiwi": purchasePrice = 3.00 * quantity; break;
                    case "pineapple": purchasePrice = 5.60 * quantity; break;
                    case "grapes": purchasePrice = 4.20 * quantity; break;
                    default: Console.WriteLine("error"); break;
                }
                if (purchasePrice != 0)
                {
                    Console.WriteLine($"{purchasePrice:F2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
