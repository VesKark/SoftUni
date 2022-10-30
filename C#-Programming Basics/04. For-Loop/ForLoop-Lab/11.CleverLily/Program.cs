using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            // Estimating collected money:
            double sumToys = 0;
            double sumSavings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumSavings += (10.00 * i / 2) - 1.00; //1.00 lv. taken from her brother
                }
                else
                {
                    sumToys += priceToy;
                }
            }

            // Output:
            double totalSavings = sumToys + sumSavings;

            if (totalSavings >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {totalSavings - priceWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - totalSavings:F2}");
            }
        }
    }
}
