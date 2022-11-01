using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfCharity = int.Parse(Console.ReadLine()); //days of chairty
            int bakers = int.Parse(Console.ReadLine()); //number of bakers

            int cakes = int.Parse(Console.ReadLine()); //cake quantity
            int waffle = int.Parse(Console.ReadLine()); //waffle quantity
            int pancake = int.Parse(Console.ReadLine()); //pancake quantity

            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            // gain from charity = (cakeQty * price + waffleQty * price + pancakeQty * price) * bakers * days
            double gain = (cakes * cakePrice + waffle * wafflePrice + pancake * pancakePrice) * bakers * daysOfCharity;

            // costs for charity = gain from charity / 8
            double charityCosts = gain / 8;

            // Output = gain from charity - costs for charity
            Console.WriteLine(gain - charityCosts);
        }
    }
}
