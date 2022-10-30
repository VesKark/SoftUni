using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double mackerelPrice = double.Parse(Console.ReadLine()); //price per kg
            double spratPrice = double.Parse(Console.ReadLine()); //price per kg
            double bonitoKg = double.Parse(Console.ReadLine()); //weight in kg
            double scadKg = double.Parse(Console.ReadLine()); // weight in kg
            int musselsKg = int.Parse(Console.ReadLine()); // weight in kg

            // Other prices [lv/kg]:
            double bonitoPrice = mackerelPrice * 1.60;
            double scadPrice = spratPrice * 1.80;
            double musselsPrice = 7.50;

            // Output:
            double costs = bonitoKg * bonitoPrice + scadKg * scadPrice + musselsKg * musselsPrice;
            Console.WriteLine($"{costs:F2}");
        }
    }
}
