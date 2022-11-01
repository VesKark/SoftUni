using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strawberry price from Input [lv]:
            double strawberryPrice = double.Parse(Console.ReadLine());

            // Fruit quantities from Input [kg]:
            double bananaQty = double.Parse(Console.ReadLine());
            double orangeQty = double.Parse(Console.ReadLine());
            double raspberryQty = double.Parse(Console.ReadLine());
            double strawberryQty = double.Parse(Console.ReadLine());

            // Fruit prices [lv]:
            double raspberryPrice = strawberryPrice * 0.5;
            double orangePrice = raspberryPrice * 0.6;
            double bananaPrice = raspberryPrice * 0.2;

            // Money needed:
            double neededMoney = bananaQty * bananaPrice + orangeQty * orangePrice + raspberryQty * raspberryPrice + strawberryQty * strawberryPrice;

            Console.WriteLine($"{neededMoney:F2}");
        }
    }
}
