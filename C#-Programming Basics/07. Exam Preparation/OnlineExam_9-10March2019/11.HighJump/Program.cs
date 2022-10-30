using System;

namespace _11.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int heightGoal = int.Parse(Console.ReadLine());
            bool failed = false;
            int heightReached = 0;
            int countTries = 0;

            // Practicing jums:
            for (int i = heightGoal - 30; i <= heightGoal; i += 5)
            {
                int countJumps = 0;
                bool success = false;

                for (int jumps = 1; jumps <= 3; jumps++)
                {
                    int heightJump = int.Parse(Console.ReadLine());
                    countJumps++;

                    if (heightJump > i)
                    {
                        success = true;
                        break;
                    }                    
                }
                countTries += countJumps;
                heightReached = i;

                if (countJumps == 3 && !success)
                {
                    failed = true;                    
                    break;
                }
            }

            // Printing training result:
            if (failed)
            {
                Console.WriteLine($"Tihomir failed at {heightReached}cm after {countTries} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {heightReached}cm after {countTries} jumps.");
            }
        }
    }
}
