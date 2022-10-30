using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greeningArea = double.Parse(Console.ReadLine());

            double discount = 0.18;
            double priceProM2 = 7.61;

            double totalPrice = priceProM2 * greeningArea;
            double priceOfDiscount = totalPrice * discount;
            double finalPrice = totalPrice - priceOfDiscount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {priceOfDiscount} lv.");
        }
    }
}
