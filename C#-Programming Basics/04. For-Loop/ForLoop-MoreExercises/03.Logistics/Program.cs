using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int loads = int.Parse(Console.ReadLine()); //count load transportations

            // Estimating the average price for the transport and the type of tranport vehicle:
            int totalWeight = 0;
            double totalPrice = 0;

            double percentMinibus = 0;
            double percentTruck = 0;
            double percentTrain = 0;

            for (int i = 0; i < loads; i++)
            {
                int weight = int.Parse(Console.ReadLine()); //weight to transport [t]
                totalWeight += weight;

                if (weight <= 3)
                {
                    totalPrice += weight * 200.00;
                    percentMinibus += weight;
                }
                else if (weight <= 11)
                {
                    totalPrice += weight * 175.00;
                    percentTruck += weight;
                }
                else if (weight >= 12)
                {
                    totalPrice += weight * 120.00;
                    percentTrain += weight;
                }
            }

            // Output:
            Console.WriteLine($"{totalPrice / totalWeight:F2}");
            Console.WriteLine($"{percentMinibus * 100 / totalWeight:F2}%");
            Console.WriteLine($"{percentTruck * 100 / totalWeight:F2}%");
            Console.WriteLine($"{percentTrain * 100 / totalWeight:F2}%");
        }
    }
}
