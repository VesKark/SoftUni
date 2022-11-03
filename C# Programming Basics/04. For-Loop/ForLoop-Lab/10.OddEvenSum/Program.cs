using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += inputN;
                }
                else
                {
                    sumOdd += inputN;
                }
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine($"Yes\nSum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
