using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine(); //"trail", "cross-country", "downhill" or "road"

            // Estimating donated sum:
            double donation = 0;

            switch (route)
            {
                case "trail":
                    donation = juniors * 5.50 + seniors * 7.00;
                    break;
                case "cross-country":
                    donation = juniors * 8.00 + seniors * 9.50;
                    if (juniors + seniors >= 50)
                    {
                        donation *= 0.75; //discount from 25%
                    }
                    break;
                case "downhill":
                    donation = juniors * 12.25 + seniors * 13.75;
                    break;
                case "road":
                    donation = juniors * 20.00 + seniors * 21.50;
                    break;
            }

            // Output:
            donation *= 0.95; // charging 5% for expenses

            Console.WriteLine($"{donation:F2}");
        }
    }
}
