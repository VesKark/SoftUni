using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int distance = int.Parse(Console.ReadLine()); //distance to travel [km]
            string timeOfDay = Console.ReadLine(); //"day" or "night"

            // Calculating least expensive transport:
            double transportPrice = 0;

            if (distance < 20)
            {
                if (timeOfDay == "day")
                {
                    transportPrice = 0.7 + 0.79 * distance;
                }
                else if (timeOfDay == "night")
                {
                    transportPrice = 0.7 + 0.9 * distance;
                }                
            }
            else if (distance < 100)
            {
                transportPrice = 0.09 * distance;
            }
            else if (distance >= 100)
            {
                transportPrice = 0.06 * distance;
            }

            // Output:
            Console.WriteLine($"{transportPrice:F2}");
        }
    }
}
