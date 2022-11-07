using System;

namespace _11.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countEasterBread = int.Parse(Console.ReadLine());            
            int totalPoints = 0;
            int maxPoints = int.MinValue;
            string bestBaker = string.Empty;

            // Assigning points from the competition:
            for (int i = 0; i < countEasterBread; i++)
            {
                string bakerName = Console.ReadLine();
                string input = Console.ReadLine();

                while (input != "Stop")
                {
                    int points = int.Parse(input);
                    totalPoints += points;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {totalPoints} points.");

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    bestBaker = bakerName;
                }

                totalPoints = 0;
            }

            // Printing winner name and points:
            Console.WriteLine($"{bestBaker} won competition with {maxPoints} points!");
        }
    }
}
