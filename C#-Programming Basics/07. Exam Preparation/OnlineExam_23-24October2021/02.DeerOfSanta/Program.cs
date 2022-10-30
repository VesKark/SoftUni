using System;

namespace _02.DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int daysAway = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine()); //left food in kg
            double foodPerDayDeerOne = double.Parse(Console.ReadLine()); //food per day for the first deer in kg
            double foodPerDayDeerTwo = double.Parse(Console.ReadLine()); //food per day for the second deer in kg
            double foodPerDayDeerThree = double.Parse(Console.ReadLine()); //food per day for the third deer in kg

            // Estimating if left food will be enough:
            double totalFoodNeeded = (foodPerDayDeerOne + foodPerDayDeerTwo + foodPerDayDeerThree) * daysAway;

            if (leftFood >= totalFoodNeeded)
            {
                Console.WriteLine($"{Math.Floor(leftFood - totalFoodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - leftFood)} more kilos of food are needed.");
            }
        }
    }
}
