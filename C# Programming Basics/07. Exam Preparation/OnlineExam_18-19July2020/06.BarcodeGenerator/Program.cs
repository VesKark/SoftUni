using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int rangeStart = int.Parse(Console.ReadLine());
            int rangeEnd = int.Parse(Console.ReadLine());

            // Estimating ranges:
            int firstStart = rangeStart / 1000;
            int firstEnd = rangeEnd / 1000;

            int secondStart = rangeStart % 1000 / 100;
            int secondEnd = rangeEnd % 1000 / 100;

            int thirdStart = rangeStart % 100 / 10;
            int thirdEnd = rangeEnd % 100 / 10;

            int fourthStart = rangeStart % 10;
            int fourthEnd = rangeEnd % 10;

            // Generating barcode:
            for (int i = firstStart; i <= firstEnd; i++)
            {
                for (int j = secondStart; j <= secondEnd; j++)
                {
                    for (int z = thirdStart; z <= thirdEnd; z++)
                    {
                        for (int x = fourthStart; x <= fourthEnd; x++)
                        {
                            if (i % 2 !=0 && j % 2 != 0 && z % 2 != 0 && x % 2 != 0)
                            {
                                Console.Write($"{i}{j}{z}{x} ");
                            }
                        }
                    }
                }                               
            }
        }
    }
}
