using System;

namespace _10.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            string placing = string.Empty; //"W", "F" or "SF"

            // Estimating ranking:
            int countWin = 0;
            int totalPoints = startPoints;

            for (int i = 0; i < tournaments; i++)
            {
                placing = Console.ReadLine();
                switch (placing)
                {
                    case "W":
                        countWin++;
                        totalPoints += 2000;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }

            // Output:
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {(totalPoints - startPoints) / tournaments}");
            Console.WriteLine($"{countWin * 100.00 / tournaments:F2}%");
        }
    }
}
