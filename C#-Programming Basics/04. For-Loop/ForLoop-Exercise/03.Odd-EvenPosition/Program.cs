using System;

namespace _03.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= num; i++)
            {
                double inputN = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += inputN;
                    if (inputN > evenMax)
                    {
                        evenMax = inputN;
                    }
                    if (inputN < evenMin)
                    {
                        evenMin = inputN;
                    }
                }
                else
                {
                    oddSum += inputN;
                    if (inputN > oddMax)
                    {
                        oddMax = inputN;
                    }
                    if (inputN < oddMin)
                    {
                        oddMin = inputN;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
            Console.WriteLine($"OddMin={oddMin:F2},");
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }

        }
    }
}
