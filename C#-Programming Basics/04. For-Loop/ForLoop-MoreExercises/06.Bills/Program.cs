using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int months = int.Parse(Console.ReadLine());

            // Estimating costs:
            double totalElectricity = 0;
            double totalOther = 0;

            for (int i = 0; i < months; i++)
            {
                double costsElectricity = double.Parse(Console.ReadLine());
                totalElectricity += costsElectricity;
                totalOther += (costsElectricity + 20.00 + 15.00) * 1.20;
            }

            // Output:
            double totalCosts = totalElectricity + months * (20.00 + 15.00) + totalOther;

            Console.WriteLine($"Electricity: {totalElectricity:F2} lv");
            Console.WriteLine($"Water: {months * 20.00:F2} lv");
            Console.WriteLine($"Internet: {months * 15.00:F2} lv");
            Console.WriteLine($"Other: {totalOther:F2} lv");
            Console.WriteLine($"Average: {totalCosts / months:F2} lv");
        }
    }
}
