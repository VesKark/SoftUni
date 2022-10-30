using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int hallRent = int.Parse(Console.ReadLine());

            // Estimating costs for Oscar's Ceremony:
            double costStatuette = hallRent * 0.70;
            double catering = costStatuette * 0.85;
            double soundSupport = catering / 2;

            double costs = hallRent + costStatuette + catering + soundSupport;

            // Output:
            Console.WriteLine($"{costs:F2}");
        }
    }
}
