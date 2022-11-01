using System;

namespace _09.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string serial = Console.ReadLine(); //name of the serial
            int duration = int.Parse(Console.ReadLine()); //duration of the episode
            int breaktime = int.Parse(Console.ReadLine()); //length of the break

            // Estimating time distribution during the break:
            double lunchtime = breaktime / 8.00;
            double resting = breaktime / 4.00;
            double timeForTV = breaktime - lunchtime - resting;

            if (timeForTV < duration)
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(duration - timeForTV)} more minutes.");
            }
            else
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeForTV - duration)} minutes free time.");
            }
        }
    }
}
