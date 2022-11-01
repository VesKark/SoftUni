using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string fuel = Console.ReadLine(); //fuel type: "Diesel", "Gasoline" or "Gas"
            double liter = double.Parse(Console.ReadLine()); //liter of fuel in the tank [L]

            // Output:
            switch (fuel)
            {
                case "Diesel":
                case "Gasoline":
                case "Gas":
                    if (liter >= 25)
                    {
                        Console.WriteLine($"You have enough {fuel.ToLower()}.");
                    }
                    else if (liter < 25)
                    {
                        Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }            
        }
    }
}
