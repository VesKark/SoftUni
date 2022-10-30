using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string flower = Console.ReadLine(); //"Roses", "Dahlias", "Tulips", "Narcissus" or "Gladiolus"
            int number = int.Parse(Console.ReadLine()); //number of flowers
            int budget = int.Parse(Console.ReadLine());

            // Calculating price:
            double price = 0;

            switch (flower)
            {
                case "Roses":
                    if (number > 80)
                    {
                        price = number * 5.00 * 0.90; //discount 10%
                    }
                    else
                    {
                        price = number * 5.00;
                    }
                    break;

                case "Dahlias":
                    if (number > 90)
                    {
                        price = number * 3.80 * 0.85; //discount 15%
                    }
                    else
                    {
                        price = number * 3.80;
                    }
                    break;

                case "Tulips":
                    if (number > 80)
                    {
                        price = number * 2.80 * 0.85; //discount 15%
                    }
                    else
                    {
                        price = number * 2.80;
                    }
                    break;

                case "Narcissus":
                    if (number < 120)
                    {
                        price = number * 3.00 * 1.15; //additional charge 15%
                    }
                    else
                    {
                        price = number * 3.00;
                    }
                    break;

                case "Gladiolus":
                    if (number < 80)
                    {
                        price = number * 2.50 * 1.20; //additional charge 20%
                    }
                    else
                    {
                        price = number * 2.50;
                    }
                    break;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {(budget - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");
            }
        }
    }
}
