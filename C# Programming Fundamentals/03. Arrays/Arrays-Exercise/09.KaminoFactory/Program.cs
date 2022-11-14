using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // Estimating best DNA "1"-sequence:
            int countOnes = 1;
            int countOnesBest = 1;
            int indexCurrent = 0;
            int indexBest = 0;
            int[] bestSequence = new int[length];
            int countOnesCheck = 0;
            int indexCheck = length - 1;
            int sumCheck = 0;
            int sumCurrent = 0;
            int bestSampleNr = 0;
            int sampleNr = 0;

            while (input != "Clone them!")
            {
                int[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sampleNr++;

                for (int i = 0; i < length; i++)
                {
                    sumCurrent += sequence[i];
                }

                // 1. Estimating index and count for current array:
                for (int i = 0; i < length - 1; i++)
                {
                    if (sequence[i] == 1 && sequence[i] == sequence[i + 1])
                    {
                        countOnes++;
                        if (countOnes == 2)
                        {
                            indexCurrent = i;
                        }

                        if (countOnes > countOnesBest)
                        {
                            countOnesBest = countOnes;
                            indexBest = indexCurrent;
                        }
                    }
                    else
                    {
                        countOnes = 1;
                    }
                }
                //Console.WriteLine(countOnesBest);
                //Console.WriteLine(indexBest);

                //2. Comparing arrays:
                if (countOnesBest > countOnesCheck)
                {
                    bestSampleNr = sampleNr;
                    countOnesCheck = countOnesBest;
                    indexCheck = indexBest;
                    sumCheck = sumCurrent;
                    for (int i = 0; i < length; i++)
                    {
                        bestSequence[i] = sequence[i];
                    }
                }
                else if (countOnesBest == countOnesCheck && indexBest < indexCheck)
                {
                    bestSampleNr = sampleNr;
                    countOnesCheck = countOnesBest;
                    indexCheck = indexBest;
                    sumCheck = sumCurrent;
                    for (int i = 0; i < length; i++)
                    {
                        bestSequence[i] = sequence[i];
                    }
                }
                else if (countOnesBest == countOnesCheck && indexBest == indexCheck)
                {
                    if (sumCurrent > sumCheck)
                    {
                        bestSampleNr = sampleNr;
                        countOnesCheck = countOnesBest;
                        indexCheck = indexBest;
                        sumCheck = sumCurrent;
                        for (int i = 0; i < length; i++)
                        {
                            bestSequence[i] = sequence[i];
                        }
                    }
                }

                sumCurrent = 0;
                countOnes = 1;
                countOnesBest = 1;
                indexCurrent = 0;
                indexBest = 0;
                input = Console.ReadLine();
            }

            // Output:
            Console.WriteLine($"Best DNA sample {bestSampleNr} with sum: {sumCheck}.");
            foreach (int item in bestSequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}
