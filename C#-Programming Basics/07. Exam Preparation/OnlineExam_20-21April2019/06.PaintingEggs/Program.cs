using System;

namespace _06.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string eggsSize = Console.ReadLine(); //"Large", "Medium" или "Small"
            string eggsColor = Console.ReadLine(); //"Red", "Green" или "Yellow"
            int eggsSets = int.Parse(Console.ReadLine());

            // Assigning prices per eggs set:
            double eggPrice = 0;

            if (eggsSize == "Large")
            {
                switch (eggsColor)
                {
                    case "Red": eggPrice = 16; break;
                    case "Green": eggPrice = 12; break;
                    case "Yellow": eggPrice = 9; break;
                }
            }
            else if (eggsSize == "Medium")
            {
                switch (eggsColor)
                {
                    case "Red": eggPrice = 13; break;
                    case "Green": eggPrice = 9; break;
                    case "Yellow": eggPrice = 7; break;
                }
            }
            else if (eggsSize == "Small")
            {
                switch (eggsColor)
                {
                    case "Red": eggPrice = 9; break;
                    case "Green": eggPrice = 8; break;
                    case "Yellow": eggPrice = 5; break;
                }
            }

            // Output total price:
            double productionWin = eggPrice * eggsSets * 0.65; //-35% for production costs

            Console.WriteLine($"{productionWin:F2} leva.");
        }
    }
}
