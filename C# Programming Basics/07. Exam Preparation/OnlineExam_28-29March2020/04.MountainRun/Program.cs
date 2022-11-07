using System;

namespace _04.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double timeBest = double.Parse(Console.ReadLine()); //best score in seconds
            double distance = double.Parse(Console.ReadLine()); //bdistance in meter
            double speed = double.Parse(Console.ReadLine()); //speed for 1 m [sec/m]

            // Estimating time needed for the climb in seconds:
            double timeWithoutDelay = distance * speed;
            double timeDelay = Math.Floor(distance / 50) * 30; //delay from 30sec at every 50m

            double timeTotal = timeWithoutDelay + timeDelay;

            // Output:
            if (timeTotal < timeBest)
            {
                Console.WriteLine($"Yes! The new record is {timeTotal:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {timeTotal - timeBest:F2} seconds slower.");
            }
        }
    }
}
