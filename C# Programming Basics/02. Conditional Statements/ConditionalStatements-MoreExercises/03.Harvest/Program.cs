using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int vineyardArea = int.Parse(Console.ReadLine()); //vineyard area [m2]
            double grapes = double.Parse(Console.ReadLine()); //grapes [kg/m2]
            int wineNeeded = int.Parse(Console.ReadLine()); //needed wine [L]
            int workers = int.Parse(Console.ReadLine()); //number of workers

            // Wine production:
            double harvest = grapes * vineyardArea; //grape harvest [kg]
            double wineProduced = 0.4 * harvest / 2.5; //40% of harvest -> 2.5 kg grapes for 1.0 L wine

            // Comparing wineNeeded and wineProduced:
            double deltaWine = wineProduced - wineNeeded;

            if (deltaWine < 0)
            {
                deltaWine = Math.Abs(deltaWine);
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(deltaWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(deltaWine)} liters left -> {Math.Ceiling(deltaWine / workers)} liters per person.");
            }
        }
    }
}
