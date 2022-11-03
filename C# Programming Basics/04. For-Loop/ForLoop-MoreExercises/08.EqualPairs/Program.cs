using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num = int.Parse(Console.ReadLine());

            // Checking pairs:
            int inputN1 = int.Parse(Console.ReadLine());
            int inputN2 = int.Parse(Console.ReadLine());

            int pairSum1 = inputN1 + inputN2;
            int pairSum2 = 0;
            int maxDiff = int.MinValue;
            bool equalPairs = true;

            for (int i = 0; i < num - 1; i++)
            {
                pairSum1 = inputN1 + inputN2;
                inputN1 = int.Parse(Console.ReadLine());
                inputN2 = int.Parse(Console.ReadLine());

                pairSum2 = inputN1 + inputN2;

                if (Math.Abs(pairSum1 - pairSum2) > maxDiff)
                {
                    maxDiff = Math.Abs(pairSum1 - pairSum2);
                }

                if (pairSum1 != pairSum2)
                {
                    equalPairs = false;
                }
            }

            // Output:
            if (equalPairs)
            {
                Console.WriteLine($"Yes, value={pairSum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
