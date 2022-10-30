using System;

namespace _02.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int trainingFee1Year = int.Parse(Console.ReadLine());

            // Calculating costs:
            double sneakers = trainingFee1Year * 0.60; //40% less than fee
            double outfit = sneakers * 0.80; //20% less than sneakers
            double ball = outfit / 4;
            double accessories = ball / 5;

            // Output:
            Console.WriteLine($"{trainingFee1Year + sneakers + +outfit + ball + accessories:F2}");
        }
    }
}
