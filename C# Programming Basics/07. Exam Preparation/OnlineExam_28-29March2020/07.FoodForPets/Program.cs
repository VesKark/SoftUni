using System;

namespace _07.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine());
            double foodQtyTotal = double.Parse(Console.ReadLine());

            // Preparing feeding statistics:
            int foodQtyDog = 0;
            int foodQtyCat = 0;
            int foodSumDog = 0;
            int foodSumCat = 0;
            double cookies = 0;

            for (int i = 1; i <= days; i++)
            {
                foodQtyDog = int.Parse(Console.ReadLine());
                foodQtyCat = int.Parse(Console.ReadLine());

                foodSumDog += foodQtyDog;
                foodSumCat += foodQtyCat;

                if (i % 3 == 0)
                {
                    cookies += (foodQtyDog + foodQtyCat) * 0.10;
                }
            }

            // Output:
            int foodQtyEaten = foodSumDog + foodSumCat;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{foodQtyEaten * 100.00 / foodQtyTotal:F2}% of the food has been eaten.");
            Console.WriteLine($"{foodSumDog * 100.00 / foodQtyEaten:F2}% eaten from the dog.");
            Console.WriteLine($"{foodSumCat * 100.00 / foodQtyEaten:F2}% eaten from the cat.");
        }
    }
}
