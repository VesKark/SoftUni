using System;

namespace _01.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double strawberryPrice = double.Parse(Console.ReadLine()); //strawberry price [lv/kg]
            double bananaQty = double.Parse(Console.ReadLine()); //banana [kg]
            double orangeQty = double.Parse(Console.ReadLine()); //orange [kg]
            double raspberryQty = double.Parse(Console.ReadLine()); //raspberry [kg]
            double strawberryQty = double.Parse(Console.ReadLine()); //strawberry [kg]

            // Estimating needed money:
            double price = strawberryQty * strawberryPrice;
            price += raspberryQty * (strawberryPrice / 2);
            price += orangeQty * (strawberryPrice / 2) * 0.60;
            price += bananaQty * (strawberryPrice / 2) * 0.20;

            // Output:
            Console.WriteLine($"{price:F2}");
        }
    }
}
