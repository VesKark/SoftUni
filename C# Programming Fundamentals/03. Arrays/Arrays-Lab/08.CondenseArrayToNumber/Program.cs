using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Find final sum:
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
