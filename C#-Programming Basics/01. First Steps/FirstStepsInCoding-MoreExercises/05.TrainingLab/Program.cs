using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hall sizes:
            double hallLength = double.Parse(Console.ReadLine()); //input in [m]
            double hallWidth = double.Parse(Console.ReadLine()); //input in [m]

            // Hall working places:
            double workingPlacesL = Math.Floor(hallLength / 1.20); //places in length
            double workingPlacesW = Math.Floor((hallWidth - 1.00) / 0.70); //places in width (minus corridor width from 1.0m)

            // Output:
            double workingPlacesInTotal = workingPlacesL * workingPlacesW - 3; //working places in total (minus desk and entrance area)
            Console.WriteLine(workingPlacesInTotal);
        }
    }
}
