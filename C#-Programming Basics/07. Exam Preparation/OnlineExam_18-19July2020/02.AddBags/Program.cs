using System;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double luggageOver20kg = double.Parse(Console.ReadLine()); // price of luggage, weight over 20 kg
            double luggageWeight = double.Parse(Console.ReadLine());
            int daysTillTravel = int.Parse(Console.ReadLine());
            int luggagePeaces = int.Parse(Console.ReadLine());

            // Estimating costs for luggage:
            
                // 1. Estimating taxis for overweight:
            double priceLuggage = 0;

            if (luggageWeight < 10)
            {
                priceLuggage = luggageOver20kg * 0.20; // 20% of luggage price
            }
            else if (luggageWeight <= 20)
            {
                priceLuggage = luggageOver20kg * 0.50; // 50% of luggage price
            }
            else if (luggageWeight > 20)
            {
                priceLuggage = luggageOver20kg;
            }
           
                // 2. Additional costs for luggage:
            if (daysTillTravel < 7)
            {
                priceLuggage *= 1.40; // 40% more
            }
            else if (daysTillTravel <= 30)
            {
                priceLuggage *= 1.15; // 15% more
            }
            else if (daysTillTravel > 30)
            {
                priceLuggage *= 1.10; // 10% more
            }

            // Output - total costs:
            priceLuggage *= luggagePeaces;
            Console.WriteLine($"The total price of bags is: {priceLuggage:F2} lv.");
        }
    }
}
