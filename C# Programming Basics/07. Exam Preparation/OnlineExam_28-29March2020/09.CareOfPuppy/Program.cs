using System;

namespace _09.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int foodQtyTotal = int.Parse(Console.ReadLine()) * 1000; //in gramm
            string input = Console.ReadLine();

            // Estimating if food is enough:
            int foodEaten = 0;
            int foodEatenTotal = 0;

            while (input != "Adopted")
            {
                foodEaten = int.Parse(input);
                foodEatenTotal += foodEaten;

                input = Console.ReadLine();
            }

            // Output:
            if (foodEatenTotal <= foodQtyTotal)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodQtyTotal - foodEatenTotal} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodEatenTotal - foodQtyTotal} grams more.");
            }
        }
    }
}
