using System;

namespace _08.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int eggsAtShop = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int soldEggs = 0;

            // Counting sold eggs:
            while (input != "Close")
            {
                int newEggs = int.Parse(Console.ReadLine());

                if (input == "Buy")
                {
                    if (newEggs > eggsAtShop)
                    {
                        break;
                    }
                    else
                    {
                        soldEggs += newEggs;
                        eggsAtShop -= newEggs;
                    }
                }
                else if (input == "Fill")
                {
                    eggsAtShop += newEggs;
                }

                input = Console.ReadLine();
            }

            // Output:
            if (input == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
            else
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {eggsAtShop}.");
            }
        }
    }
}
