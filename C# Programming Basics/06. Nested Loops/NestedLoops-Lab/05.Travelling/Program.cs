using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string destination = Console.ReadLine();
            double minBudget = 0;
            if (destination != "End")
            {
                minBudget = double.Parse(Console.ReadLine());
            }

            // Saving money for travel:
            double savings = 0;
            double savingsSum = 0;

            while (destination != "End")
            {
                savings = double.Parse(Console.ReadLine());
                savingsSum += savings;

                if (savingsSum >= minBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savingsSum = 0;
                    destination = Console.ReadLine();
                    if (destination != "End")
                    {
                        minBudget = double.Parse(Console.ReadLine());
                    }
                }                
            }
        }
    }
}
