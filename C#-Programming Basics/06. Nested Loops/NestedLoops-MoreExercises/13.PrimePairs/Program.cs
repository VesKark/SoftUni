using System;

namespace _13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int pairOneStart = int.Parse(Console.ReadLine());
            int pairTwoStart = int.Parse(Console.ReadLine());
            int pairOneDiff = int.Parse(Console.ReadLine());
            int pairTwoDiff = int.Parse(Console.ReadLine());

            // Generating combinations:
            int countAB = 0;
            int countCD = 0;

            for (int ab = pairOneStart; ab <= pairOneStart + pairOneDiff; ab++)
            {
                for (int i = 1; i <= ab; i++)
                {
                    if (ab % i == 0)
                    {
                        countAB++;
                    }
                }

                if (countAB == 2)
                {
                    for (int cd = pairTwoStart; cd <= pairTwoStart + pairTwoDiff; cd++)
                    {
                        for (int j = 1; j <= cd; j++)
                        {
                            if (cd % j == 0)
                            {
                                countCD++;
                            }
                        }

                        if (countCD == 2)
                        {
                            Console.WriteLine($"{ab}{cd}");
                        }

                        countCD = 0;
                    }
                }

                countAB = 0;
            }
        }
    }
}
