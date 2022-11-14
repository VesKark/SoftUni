using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Comparing sum of even and odd numbers:
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
