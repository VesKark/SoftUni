using System;

namespace _06.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine()); //'m' or 'f'
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine(); //"Gym", "Boxing", "Yoga", "Zumba", "Dances" or "Pilates"

            // Estimating costs for fitness card:
            double cardPrice = 0;

            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym": cardPrice = 42.00; break;
                    case "Boxing": cardPrice = 41.00; break;
                    case "Yoga": cardPrice = 45.00; break;
                    case "Zumba": cardPrice = 34.00; break;
                    case "Dances": cardPrice = 51.00; break;
                    case "Pilates": cardPrice = 39.00; break;
                }
            }
            else if (gender == 'f')
            {
                switch (sport)
                {
                    case "Gym": cardPrice = 35.00; break;
                    case "Boxing": cardPrice = 37.00; break;
                    case "Yoga": cardPrice = 42.00; break;
                    case "Zumba": cardPrice = 31.00; break;
                    case "Dances": cardPrice = 53.00; break;
                    case "Pilates": cardPrice = 37.00; break;
                }
            }

            if (age <= 19)
            {
                cardPrice *= 0.80; //discount from 20%
            }

            // Output:
            if (cardPrice <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cardPrice - budget:F2} more.");
            }
        }
    }
}
