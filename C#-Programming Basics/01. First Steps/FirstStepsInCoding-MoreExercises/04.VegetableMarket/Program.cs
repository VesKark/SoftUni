using System;

namespace _4.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double vegetablePrice = double.Parse(Console.ReadLine()); //price of vegetables [lv/kg]
            double fruitPrice = double.Parse(Console.ReadLine()); //price of fruits [lv/kg]
            int vegetableKg = int.Parse(Console.ReadLine()); //vegetables [kg]
            int fruitKg = int.Parse(Console.ReadLine()); //fruits [kg]

            // Output:
            double income = (vegetablePrice * vegetableKg + fruitPrice * fruitKg) / 1.94; //income in Euro
            Console.WriteLine($"{income:F2}");       
        }
    }
}
