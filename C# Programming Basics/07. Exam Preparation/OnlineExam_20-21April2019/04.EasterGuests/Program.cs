using System;

namespace _04.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // Estimating costs:
            int countEggs = countGuests * 2;
            int countEasterBread = (int)Math.Ceiling(countGuests / 3.00);

            double totalCosts = countEggs * 0.45 + countEasterBread * 4.00;

            // Comparing and printing total costs and budget:
            if (budget >= totalCosts)
            {
                Console.WriteLine($"Lyubo bought {countEasterBread} Easter bread and {countEggs} eggs.");
                Console.WriteLine($"He has {budget * 1.00 - totalCosts:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalCosts - budget:F2} lv. more.");
            }
        }
    }
}
