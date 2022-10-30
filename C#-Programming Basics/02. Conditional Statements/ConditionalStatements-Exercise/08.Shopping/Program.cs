using System;

namespace _08.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            // Calculating total price:
            double videocardsTotal = videocards * 250.00;
            double processorTotal = videocardsTotal * 0.35 * processor;
            double ramTotal = videocardsTotal * 0.10 * ram;
            double totalPrice = videocardsTotal + processorTotal + ramTotal;

            if (videocards > processor)
            {
                totalPrice *= 0.85; //discount 15%
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}
