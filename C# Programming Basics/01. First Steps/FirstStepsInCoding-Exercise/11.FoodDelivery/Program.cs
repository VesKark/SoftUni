using System;

namespace _11.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegiMenu = int.Parse(Console.ReadLine());

            // Calculating costs:
            double chicken = chickenMenu * 10.35;
            double fish = fishMenu * 12.40;
            double vegi = vegiMenu * 8.15;

            double costs = chicken + fish + vegi;
            double dessert = costs * 0.20;

            // Output incl. delivery for 2.50 leva:
            Console.WriteLine(costs + dessert + 2.50);
        }
    }
}
