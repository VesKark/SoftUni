using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int poolVolume = int.Parse(Console.ReadLine()); //pool volume [L]
            int flowPipe1 = int.Parse(Console.ReadLine()); //flow of pipe 1 [L/h]
            int flowPipe2 = int.Parse(Console.ReadLine()); //flow of pipe 2 [L/h]
            double hours = double.Parse(Console.ReadLine()); //hours of pipe inflow [h]

            // Estimating volume of inflow:
            double inflowPipe1 = flowPipe1 * hours;
            double inflowPipe2 = flowPipe2 * hours;
            double totalInflow = inflowPipe1 + inflowPipe2;

            // Check if pool overflows:
            if (inflowPipe1 + inflowPipe2 > poolVolume)
            {
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {totalInflow - poolVolume:F2} liters.");
            }

            // Check how full is the pool:
            else
            {
                Console.WriteLine($"The pool is {totalInflow / poolVolume * 100:F2}% full. Pipe 1: {inflowPipe1 / totalInflow * 100:F2}%. Pipe 2: {inflowPipe2 / totalInflow * 100:F2}%.");
            }
        }
    }
}
