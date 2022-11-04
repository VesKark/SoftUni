using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine()); //count of students
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            // Estimating costs for equipment:
            double totalLightsaber = Math.Ceiling(students * 1.10) * priceLightsaber;
            double totalRobes = students * priceRobes;
            double totalBelts = (students - (students / 6)) * priceBelts;
            
            double totalCosts = totalLightsaber + totalRobes + totalBelts;

            // Output:
            if (budget >= totalCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCosts:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCosts - budget:F2}lv more.");
            }
        }
    }
}
