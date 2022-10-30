using System;

namespace _09.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int climbersGroups = int.Parse(Console.ReadLine());
            int climbers = 0; //climbers in a group

            // Estimating percentage of climbers on the different peaks:
            int countMusala = 0;
            int countMonblan = 0;
            int countKilimangaro = 0;
            int countK2 = 0;
            int countEverest = 0;
            int climbersTotal = 0;

            for (int i = 1; i <= climbersGroups; i++)
            {
                climbers = int.Parse(Console.ReadLine());
                climbersTotal += climbers;

                if (climbers <= 5)
                {
                    countMusala += climbers;
                }
                else if (climbers <= 12)
                {
                    countMonblan += climbers;
                }
                else if (climbers <= 25)
                {
                    countKilimangaro += climbers;
                }
                else if (climbers <= 40)
                {
                    countK2 += climbers;
                }
                else
                {
                    countEverest += climbers;
                }
            }

            // Output:
            Console.WriteLine($"{countMusala * 100.00 / climbersTotal:F2}%");
            Console.WriteLine($"{countMonblan * 100.00 / climbersTotal:F2}%");
            Console.WriteLine($"{countKilimangaro * 100.00 / climbersTotal:F2}%");
            Console.WriteLine($"{countK2 * 100.00 / climbersTotal:F2}%");
            Console.WriteLine($"{countEverest * 100.00 / climbersTotal:F2}%");
        }
    }
}