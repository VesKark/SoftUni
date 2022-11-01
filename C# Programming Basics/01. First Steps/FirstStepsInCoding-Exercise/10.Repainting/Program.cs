using System;

namespace _10.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int nylon = int.Parse(Console.ReadLine()); //nylon [m2]
            int paint = int.Parse(Console.ReadLine()); //paint [L]
            int thinner = int.Parse(Console.ReadLine()); //thinner [L]
            int workingHours = int.Parse(Console.ReadLine()); //hours to finish the work [h]

            // Calculating costs:
            double costsNylon = (nylon + 2) * 1.50;
            double costsPaint = paint * 1.10 * 14.50;
            double costsThinner = thinner * 5.00;

            double costsMaterials = costsNylon + costsPaint + costsThinner + 0.40; //including 0.40 lv for plastic bags
            double costsWorkers = costsMaterials * 0.30 * workingHours;

            // Output:
            Console.WriteLine(costsMaterials + costsWorkers);
        }
    }
}
