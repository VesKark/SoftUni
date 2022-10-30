using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketCount = int.Parse(Console.ReadLine());
            int trainersCount = int.Parse(Console.ReadLine());

            // Estimating costs for sport equipment:
            double trainersPrice = tennisRacketPrice / 6;
            double totalRackets = tennisRacketCount * tennisRacketPrice;
            double totalTrainers = trainersCount * trainersPrice;
            double totalAdditional = (totalRackets + totalTrainers) * 0.20; //adding costs for additional equipment = 20%
            double totalCosts = totalTrainers + totalRackets + totalAdditional;

            // Output price to be paid:
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalCosts / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalCosts * 7 / 8)}");
        }
    }
}
