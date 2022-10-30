using System;

namespace _05.ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countTripSea = int.Parse(Console.ReadLine());
            int countTripMountain = int.Parse(Console.ReadLine());

            string tripType = Console.ReadLine();

            // Estimating sold trips:
            int totalPrice = 0;

            while (tripType != "Stop")
            {
                if (tripType == "sea" && countTripSea > 0)
                {
                    countTripSea--;
                    totalPrice += 680;
                }
                else if (tripType == "mountain" && countTripMountain > 0)
                {
                    countTripMountain--;
                    totalPrice += 499;
                }

                if (countTripSea == 0 && countTripMountain == 0)
                {
                    break;
                }

                tripType = Console.ReadLine();
            }

            // Output:
            if (countTripSea == 0 && countTripMountain == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            
            Console.WriteLine($"Profit: {totalPrice} leva.");            
        }
    }
}
