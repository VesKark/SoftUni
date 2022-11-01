using System;

namespace _09.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int pens = int.Parse(Console.ReadLine()); //number of pen packages
            int markers = int.Parse(Console.ReadLine()); //number of marker packages
            int cleaner = int.Parse(Console.ReadLine()); //cleaning material [L]
            int discount = int.Parse(Console.ReadLine()); //discount [%] from the total sum

            //Calculating costs:
            double costsPens = pens * 5.80;
            double costsMarkers = markers * 7.20;
            double costsCleaner = cleaner * 1.20;

            double totalCosts = costsPens + costsMarkers + costsCleaner;
            totalCosts = totalCosts - (discount / 100.0) * totalCosts;

            // Output:
            Console.WriteLine(totalCosts);
        }
    }
}
