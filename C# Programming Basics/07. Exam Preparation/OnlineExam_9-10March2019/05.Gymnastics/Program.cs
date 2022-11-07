using System;

namespace _05.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string country = Console.ReadLine(); //"Russia", "Bulgaria" or "Italy"
            string apparatus = Console.ReadLine(); //"ribbon", "hoop" or "rope"

            // Assigning points:
            double pointsDifficulty = 0;
            double pointsExecution = 0;

            if (apparatus == "ribbon")
            {
                switch (country)
                {
                    case "Russia":
                        pointsDifficulty = 9.100;
                        pointsExecution = 9.400;
                        break;
                    case "Bulgaria":
                        pointsDifficulty = 9.600;
                        pointsExecution = 9.400;
                        break;
                    case "Italy":
                        pointsDifficulty = 9.200;
                        pointsExecution = 9.500;
                        break;
                }
            }
            else if (apparatus == "hoop")
            {
                switch (country)
                {
                    case "Russia":
                        pointsDifficulty = 9.300;
                        pointsExecution = 9.800;
                        break;
                    case "Bulgaria":
                        pointsDifficulty = 9.550;
                        pointsExecution = 9.750;
                        break;
                    case "Italy":
                        pointsDifficulty = 9.450;
                        pointsExecution = 9.350;
                        break;
                }
            }
            else if (apparatus == "rope")
            {
                switch (country)
                {
                    case "Russia":
                        pointsDifficulty = 9.600;
                        pointsExecution = 9.000;
                        break;
                    case "Bulgaria":
                        pointsDifficulty = 9.500;
                        pointsExecution = 9.400;
                        break;
                    case "Italy":
                        pointsDifficulty = 9.700;
                        pointsExecution = 9.150;
                        break;
                }
            }

            // Printing results:
            double totalSum = pointsDifficulty + pointsExecution;

            Console.WriteLine($"The team of {country} get {totalSum:F3} on {apparatus}.");
            Console.WriteLine($"{(100 - totalSum * 100.00 / 20):F2}%");
        }
    }
}
