using System;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fuel prices:
                gasoline = 2.22 lv/liter
                diesel = 2.33 lv/liter
                gas = 0.93 lv/liter
            */

            // Input:
            string fuel = Console.ReadLine(); //fuel type: "Gas", "Gasoline" or "Diesel"
            double liter = double.Parse(Console.ReadLine()); //liter of fuel [L]
            string discountCard = Console.ReadLine(); //"Yes" or "No"

            // Check for discount:
            double fuelPrice = 0;

            switch (fuel)
            {
                case "Gas": fuelPrice = 0.93; break;
                case "Gasoline": fuelPrice = 2.22; break;
                case "Diesel": fuelPrice = 2.33; break;
            }

            if (discountCard == "Yes")
            {
                if (fuel == "Gas")
                {
                    fuelPrice -= 0.08;
                }
                else if (fuel == "Gasoline")
                {
                    fuelPrice -= 0.18;
                }
                else if (fuel == "Diesel")
                {
                    fuelPrice -= 0.12;
                }
            }

            // Final price:
            double finalPrice = 0;

            if (liter >= 20 && liter <= 25)
            {
                finalPrice = liter * fuelPrice * 0.92; //additional discount from 8%
            }
            else if (liter > 25)
            {
                finalPrice = liter * fuelPrice * 0.90; //additional discount from 10%
            }
            else
            {
                finalPrice = liter * fuelPrice;
            }

            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
