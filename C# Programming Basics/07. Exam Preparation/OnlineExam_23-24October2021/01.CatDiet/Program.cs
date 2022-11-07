using System;

namespace _01.CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int pеrcentageFat = int.Parse(Console.ReadLine());
            int pеrcentageProtein = int.Parse(Console.ReadLine());
            int pеrcentageCarb = int.Parse(Console.ReadLine());
            int caloriesTotal = int.Parse(Console.ReadLine());
            int pеrcentageWater = int.Parse(Console.ReadLine());

            // Estimating calorites per gramm:
            double grammFat = pеrcentageFat * caloriesTotal / 9.00;
            double grammProtein = pеrcentageProtein  * caloriesTotal / 4.00;
            double grammCarb = pеrcentageCarb * caloriesTotal / 4.00;
            double totalWeight = grammFat + grammProtein + grammCarb;
            double caloriesPerGramm = (caloriesTotal / totalWeight) * (100 - pеrcentageWater); //deducting percentage of water

            // Output:
            Console.WriteLine($"{caloriesPerGramm:F4}");
        }
    }
}
