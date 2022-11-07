using System;

namespace _03.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countGuests = int.Parse(Console.ReadLine());
            double priceForOne = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cakePrice = budget * 0.10;

            // Estimating party costs:
            if (countGuests > 20)
            {
                priceForOne *= 0.75; //discount 25%
            }
            else if (countGuests > 15)
            {
                priceForOne *= 0.80; //discount 20%
            }
            else if (countGuests >= 10)
            {
                priceForOne *= 0.85; //discount 15%
            }

            double partyCosts = priceForOne * countGuests + cakePrice;

            // Comparting and printing party costs and budget:
            if (budget >= partyCosts)
            {
                Console.WriteLine($"It is party time! {budget - partyCosts:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {partyCosts - budget:F2} leva needed.");
            }
        }
    }
}
