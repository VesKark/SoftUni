using System;

namespace _10.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countEasterBread = int.Parse(Console.ReadLine());
            int totalSugar = 0;
            int totalFlour = 0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            
            // Baking easter bread:
            for (int i = 0; i < countEasterBread; i++)
            {
                int grammSugar = int.Parse(Console.ReadLine());
                int grammFlour = int.Parse(Console.ReadLine());
                totalSugar += grammSugar;
                totalFlour += grammFlour;

                if (grammSugar > maxSugar)
                {
                    maxSugar = grammSugar;
                }
                if (grammFlour > maxFlour)
                {
                    maxFlour = grammFlour;
                }
            }

            // Output:
            Console.WriteLine($"Sugar: {Math.Ceiling(totalSugar * 1.00 / 950)}");
            Console.WriteLine($"Flour: {Math.Ceiling(totalFlour * 1.00 / 750)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
