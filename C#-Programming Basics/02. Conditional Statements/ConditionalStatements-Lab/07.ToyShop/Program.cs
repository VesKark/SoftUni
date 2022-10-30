using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Prices of toys:
                puzzle = 2.60 lv
                doll = 3.00 lv
                teddy = 4.10 lv
                minion = 8.20 lv
                truck = 2.00 lv            */

            // Input:
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine()); //puzzles quantity
            int dolls = int.Parse(Console.ReadLine()); //dolls quantity
            int teddys = int.Parse(Console.ReadLine()); //teddys quantity
            int minions = int.Parse(Console.ReadLine()); //minions quantity
            int trucks = int.Parse(Console.ReadLine()); //trucks quantity

            double priceAllToys = puzzles * 2.6 + dolls * 3.00 + teddys * 4.10 + minions * 8.20 + trucks * 2.00;
            int quantityAllToys = puzzles + dolls + teddys + minions + trucks;

            if (quantityAllToys >= 50)
            {
                priceAllToys = priceAllToys * 0.75;
            }

            double rent = priceAllToys * 0.10;
            double moneyForExcursion = priceAllToys - rent;

            if(moneyForExcursion >= excursionPrice)
            {
                Console.WriteLine($"Yes! {(moneyForExcursion - excursionPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(excursionPrice - moneyForExcursion):F2} lv needed.");
            }
        }
    }
}
