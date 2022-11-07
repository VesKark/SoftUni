using System;

namespace _10.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int fitnessVisitors = int.Parse(Console.ReadLine());

            // Assigning fitness activities:
            int countBack = 0;
            int countChest = 0;
            int countLegs = 0;
            int countAbs = 0;
            int countShakes = 0;
            int countBars = 0;

            for (int i = 0; i < fitnessVisitors; i++)
            {
                string activity = Console.ReadLine(); //"Back", "Chest", "Legs", "Abs", "Protein shake" or "Protein bar"
                switch (activity)
                {
                    case "Back": countBack++; break;
                    case "Chest": countChest++; break;
                    case "Legs": countLegs++; break;
                    case "Abs": countAbs++; break;
                    case "Protein shake": countShakes++; break;
                    case "Protein bar": countBars++; break;
                }
            }

            // Printing statistics:
            int activeTraining = countBack + countChest + countLegs + countAbs;
            int passiveTraining = countShakes + countBars;

            Console.WriteLine($"{countBack} - back");
            Console.WriteLine($"{countChest} - chest");
            Console.WriteLine($"{countLegs} - legs");
            Console.WriteLine($"{countAbs} - abs");
            Console.WriteLine($"{countShakes} - protein shake");
            Console.WriteLine($"{countBars} - protein bar");
            Console.WriteLine($"{activeTraining * 100.00 / (activeTraining + passiveTraining):F2}% - work out");
            Console.WriteLine($"{passiveTraining * 100.00 / (activeTraining + passiveTraining):F2}% - protein");
        }
    }
}
