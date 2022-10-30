using System;

namespace _12.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string tournamentName = Console.ReadLine();

            // Counting tournament points:
            int countWins = 0;
            int countLosses = 0;

            while (tournamentName != "End of tournaments")
            {
                int countGames = int.Parse(Console.ReadLine());
                for (int i = 1; i <= countGames; i++)
                {
                    string result = "";
                    int pointsDiff = 0;

                    int pointsDesi = int.Parse(Console.ReadLine());
                    int pointsOpponent = int.Parse(Console.ReadLine());

                    if (pointsDesi > pointsOpponent)
                    {
                        result = "win";
                        pointsDiff = pointsDesi - pointsOpponent;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: {result} with {pointsDiff} points.");
                        countWins++;
                    }
                    else
                    {
                        result = "lost";
                        pointsDiff = pointsOpponent - pointsDesi;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: {result} with {pointsDiff} points.");
                        countLosses++;
                    }
                }

                tournamentName = Console.ReadLine();
            }

            // Output compare Win-Loss:
            Console.WriteLine($"{countWins * 100.00 / (countWins + countLosses):F2}% matches win");
            Console.WriteLine($"{countLosses * 100.00 / (countWins + countLosses):F2}% matches lost");
        }
    }
}
