using System;

namespace _04.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double gullyLength = double.Parse(Console.ReadLine()); //gully length in meter
            int secondsFor100Meter = int.Parse(Console.ReadLine()); //seconds for making 100 meter

            // Estimating time needed to make the gully:
            double controlTime = minutes * 60 + seconds; //control time in seconds
            double delay = gullyLength / 120 * 2.5;
            double neededTime = gullyLength / 100 * secondsFor100Meter - delay;

            // Output:
            if (neededTime <= controlTime)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {neededTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {neededTime - controlTime:F3} second slower.");
            }
        }
    }
}
