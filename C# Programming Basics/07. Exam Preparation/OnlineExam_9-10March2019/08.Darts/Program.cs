using System;

namespace _08.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string playerName = Console.ReadLine();
            string command = Console.ReadLine();

            // Counting darts points:
            int countGoodShots = 0;
            int countBadShots = 0;
            int result = 301;

            while (command != "Retire")
            {
                int points = int.Parse(Console.ReadLine());                

                switch (command)
                {                     
                    case "Double": points *= 2; break;
                    case "Triple": points *= 3; break;
                }                

                if (points < result)
                {
                    result -= points;
                    countGoodShots++;
                }
                else if (points == result)
                {
                    result -= points;
                    countGoodShots++;
                    break;
                }
                else
                {
                    countBadShots++;
                }

                command = Console.ReadLine();
            }

            // Output:
            if (result == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {countGoodShots} shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} retired after {countBadShots} unsuccessful shots.");
            }
        }
    }
}
