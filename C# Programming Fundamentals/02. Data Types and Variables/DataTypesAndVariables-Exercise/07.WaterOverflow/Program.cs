using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countRefills = int.Parse(Console.ReadLine());

            // Filling the tank:
            int tankVolume = 0; //max = 255 Liter

            for (int i = 0; i < countRefills; i++)
            {
                int refill = int.Parse(Console.ReadLine());

                if (tankVolume + refill <= 255)
                {
                    tankVolume += refill;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            // Output:
            Console.WriteLine(tankVolume);
        }
    }
}
