using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array:
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Print sum of only even numbers:
            int sumEven = 0;

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}
