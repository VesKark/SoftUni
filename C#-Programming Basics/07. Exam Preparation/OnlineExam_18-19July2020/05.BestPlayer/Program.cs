using System;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string player = Console.ReadLine(); //name of the player
            int goals = 0;
            bool hattrick = false;

            // Comparing players:
            int goalsMax = int.MinValue;
            string bestPlayer = "";

            while (player != "END")
            {
                goals = int.Parse(Console.ReadLine());

                if (goals > goalsMax)
                {
                    goalsMax = goals;
                    bestPlayer = player;
                }

                if (goals >= 3)
                {
                    hattrick = true;
                }

                if (goals >= 10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            // Output:
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (hattrick)
            {
                Console.WriteLine($"He has scored {goalsMax} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsMax} goals.");
            }
        }
    }
}
