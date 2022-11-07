using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int startAA = int.Parse(Console.ReadLine());
            int startAB = int.Parse(Console.ReadLine());
            int startBA = int.Parse(Console.ReadLine());
            int startBB = int.Parse(Console.ReadLine());

            // Estimating possible substitutes:
            int countSubstitutes = 6;

            for (int i = startAA; i <= 8; i++)
            {
                for (int j = 9; j >= startAB; j--)
                {
                    for (int k = startBA; k <= 8; k++)
                    {
                        for (int l = 9; l >= startBB; l--)
                        {
                            if (i % 2 == 0 && j % 2 != 0 && k % 2 == 0 && l % 2 != 0)
                            {
                                int substituteOne = i * 10 + j;
                                int substituteTwo = k * 10 + l;

                                if (substituteOne == substituteTwo)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{j} - {k}{l}");
                                    countSubstitutes--;

                                    if (countSubstitutes == 0)
                                    {
                                        return;
                                    }
                                }
                            }                            
                        }
                    }
                }
            }
        }
    }
}
