using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double swimmingRecord = double.Parse(Console.ReadLine()); //world swimming record [sec]
            double distance = double.Parse(Console.ReadLine()); //swimming distance [m]
            double timeFor1meter = double.Parse(Console.ReadLine()); //swimming speed - seconds for 1 meter [sec/m]

            // Time needed to swim the full distance:
            double delay = Math.Floor(distance / 15) * 12.5; //delay from 12.5 seconds in every 15 meter distance
            double swimmingTime = distance * timeFor1meter + delay;

            // Check if swimmingTime is a new word record:
            if (swimmingTime < swimmingRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimmingTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {swimmingTime - swimmingRecord:F2} seconds slower.");
            }
        }
    }
}
