using System;

namespace _11.OddAndEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num = int.Parse(Console.ReadLine());

            // Estimating SUM, MAX, MIN values for Odd and Even positions:
            double input = 0;
            double sumOdd = 0;
            double sumEven = 0;
            double maxOdd = double.MinValue;
            double maxEven = double.MinValue;
            double minOdd = double.MaxValue;
            double minEven = double.MaxValue;

            for (int i = 1; i <= num; i++)
            {
                input = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumOdd += input;

                    if (input > maxOdd)
                    {
                        maxOdd = input;
                    }
                    if (input < minOdd)
                    {
                        minOdd = input;
                    }
                }
                else
                {
                    sumEven += input;

                    if (input > maxEven)
                    {
                        maxEven = input;
                    }
                    if (input < minEven)
                    {
                        minEven = input;
                    }
                }
            }

            // Output - odd positions:
            Console.WriteLine($"OddSum={sumOdd:F2},");
            if (minOdd == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }

            // Output - even positions:
            Console.WriteLine($"EvenSum={sumEven:F2},");
            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }
        }
    }
}
