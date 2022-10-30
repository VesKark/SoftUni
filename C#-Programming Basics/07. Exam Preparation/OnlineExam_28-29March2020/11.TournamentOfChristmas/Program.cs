using System;

namespace _11.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine());
            string sport = "";
            bool win = true; //"win" = TRUE, "lose" = FALSE

            // Estimating wins and losses:
            double pointsDay = 0;
            double pointsTotal = 0;
            int countWinDay = 0;
            int countLoseDay = 0;
            int countWinAll = 0;
            int countLoseAll = 0;

            for (int i = 1; i <= days; i++)
            {
                sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    win = Console.ReadLine() == "win";
                    if (win)
                    {
                        pointsDay += 20.00;
                        countWinDay++;
                    }
                    else
                    {
                        countLoseDay++;
                    }
                    
                    sport = Console.ReadLine();
                }

                if (countWinDay > countLoseDay)
                {
                    pointsDay *= 1.10; //additional win from 10%
                }

                countWinAll += countWinDay;
                countLoseAll += countLoseDay;
                pointsTotal += pointsDay;
                pointsDay = 0;
                countWinDay = 0;
                countLoseDay = 0;
            }

            // Output:
            if (countWinAll > countLoseAll)
            {
                pointsTotal *= 1.20; //additional win from 20%
                Console.WriteLine($"You won the tournament! Total raised money: {pointsTotal:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {pointsTotal:F2}");
            }
        }
    }
}
