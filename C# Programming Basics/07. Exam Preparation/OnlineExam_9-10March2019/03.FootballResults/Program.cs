using System;

namespace _03.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and Comparing match results:
            int countWin = 0;
            int countLoss = 0;
            int countDraw = 0;

            for (int i = 1; i <= 3; i++)
            {
                string resultMatch = Console.ReadLine();

                if (resultMatch[0] > resultMatch[2])
                {
                    countWin++;
                }
                else if (resultMatch[0] < resultMatch[2])
                {
                    countLoss++;
                }
                else
                {
                    countDraw++;
                }
            }

            // Output final results:
            Console.WriteLine($"Team won {countWin} games.");
            Console.WriteLine($"Team lost {countLoss} games.");
            Console.WriteLine($"Drawn games: {countDraw}");
        }
    }
}
