using System;

namespace _03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int framesCount = int.Parse(Console.ReadLine());
            string framesType = Console.ReadLine(); // "90X130", "100X150", "130X180" or "200X300"
            bool delivery = Console.ReadLine() == "With delivery"; // "With delivery" == TRUE or "Without delivery" == FALSE

            // Estimating price for frames:
            double framesUnitprice = 0;


            switch (framesType)
            {
                case "90X130":
                    framesUnitprice = 110.00;
                    if (framesCount >= 30 && framesCount < 60)
                    {
                        framesUnitprice *= 0.95; // discount 5%
                    }
                    else if (framesCount >= 60)
                    {
                        framesUnitprice *= 0.92; // discount 8%
                    }
                    break;
                case "100X150":
                    framesUnitprice = 140.00;
                    if (framesCount >= 40 && framesCount < 80)
                    {
                        framesUnitprice *= 0.94; // discount 6%
                    }
                    else if (framesCount >= 80)
                    {
                        framesUnitprice *= 0.90; // discount 10%
                    }
                    break;
                case "130X180":
                    framesUnitprice = 190.00;
                    if (framesCount >= 20 && framesCount < 50)
                    {
                        framesUnitprice *= 0.93; // discount 7%
                    }
                    else if (framesCount >= 50)
                    {
                        framesUnitprice *= 0.88; // discount 12%
                    }
                    break;
                case "200X300":
                    framesUnitprice = 250.00;
                    if (framesCount >= 25 && framesCount < 50)
                    {
                        framesUnitprice *= 0.91; // discount 9%
                    }
                    else if (framesCount >= 50)
                    {
                        framesUnitprice *= 0.86; // discount 14%
                    }
                    break;
            }

            // Output:
            double framesTotalPrice = framesUnitprice * framesCount;

            if (delivery)
            {
                framesTotalPrice += 60;
            }

            if (framesCount > 99)
            {
                framesTotalPrice *= 0.96; // additional discount from 4%
            }

            if (framesCount >= 10)
            {
                Console.WriteLine($"{framesTotalPrice:F2} BGN");
            }
            else
            {
                Console.WriteLine("Invalid order");
            }
        }
    }
}
