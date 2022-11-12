using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input count of snowballs:
            int snowballsCount = int.Parse(Console.ReadLine());

            // Estimating best snowball:
            BigInteger bestSnowball = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < snowballsCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snow / time), quality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }

            // Output best snowball:            
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestSnowball} ({bestQuality})");            
        }
    }
}
