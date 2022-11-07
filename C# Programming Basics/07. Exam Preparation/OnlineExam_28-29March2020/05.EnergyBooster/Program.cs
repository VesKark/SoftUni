using System;

namespace _05.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string fruit = Console.ReadLine(); //"Watermelon", "Mango", "Pineapple" or "Raspberry"
            bool package = Console.ReadLine() == "small"; //"small" = TRUE, "big" = FALSE
            int setNr = int.Parse(Console.ReadLine()); //ordered sets

            // Estimating the costs for the energy booster:
            double setPrice = 0;

            if (package)
            {
                switch (fruit)
                {
                    case "Watermelon": setPrice = 56.00 * 2 * setNr; break;
                    case "Mango": setPrice = 36.66 * 2 * setNr; break;
                    case "Pineapple": setPrice = 42.10 * 2 * setNr; break;
                    case "Raspberry": setPrice = 20.00 * 2 * setNr; break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "Watermelon": setPrice = 28.70 * 5 * setNr; break;
                    case "Mango": setPrice = 19.60 * 5 * setNr; break;
                    case "Pineapple": setPrice = 24.80 * 5 * setNr; break;
                    case "Raspberry": setPrice = 15.20 * 5 * setNr; break;
                }
            }

            if (setPrice >= 400 && setPrice <= 1000)
            {
                setPrice *= 0.85; //discount from 15%
            }
            else if (setPrice > 1000)
            {
                setPrice *= 0.50; //discount from 50%
            }

            // Output:
            Console.WriteLine($"{setPrice:F2} lv.");
        }
    }
}
