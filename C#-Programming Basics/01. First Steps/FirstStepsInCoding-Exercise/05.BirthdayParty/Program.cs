using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // cake = 0.20 * hall price
            // drinks = 0.55 * cake
            // animator = hall price / 3

            double hallPrice = double.Parse(Console.ReadLine());
            double cakePrice = 0.20 * hallPrice;
            double drinksPrice = 0.55 * cakePrice;
            double animator = hallPrice / 3;

            double partyCosts = hallPrice + cakePrice + drinksPrice + animator;
            Console.WriteLine(partyCosts);
        }
    }
}
