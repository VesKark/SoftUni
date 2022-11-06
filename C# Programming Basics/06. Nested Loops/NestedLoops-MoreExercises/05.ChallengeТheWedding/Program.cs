using System;

namespace _05.ChallengeТheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            // Generating possible table meetings:
            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tables--;
                    if (tables == 0)
                    {
                        return;
                    }
                }
            }
        }
    }
}
