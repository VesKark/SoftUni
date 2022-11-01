using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int freeDays = int.Parse(Console.ReadLine());
            int workingDays = 365 - freeDays;

            // Time to play in minutes per year:
            int playtimie = freeDays * 127 + workingDays * 63;

            // Comparing playtime and needed resting time (30.000 min/year):
            int deltaTime = Math.Abs(playtimie - 30000);
            int hours = deltaTime / 60;
            int minutes = deltaTime % 60;

            if (playtimie > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
