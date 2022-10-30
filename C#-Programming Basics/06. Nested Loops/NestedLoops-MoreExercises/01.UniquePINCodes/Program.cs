using System;

namespace _01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int max1Num = int.Parse(Console.ReadLine());
            int max2Num = int.Parse(Console.ReadLine());
            int max3Num = int.Parse(Console.ReadLine());

            bool primeNumber = true;

            // Generating PIN:
            for (int i = 1; i <= max1Num; i++)
            {
                for (int j = 1; j <= max2Num; j++)
                {
                    for (int z = 1; z <= max3Num; z++)
                    {
                        primeNumber = j == 2 || j == 3 || j == 5 || j == 7;
                        if (i % 2 == 0 && z % 2 == 0 && primeNumber)
                        {
                            Console.WriteLine($"{i} {j} {z}");
                        }
                    }
                }
            }
        }
    }
}
