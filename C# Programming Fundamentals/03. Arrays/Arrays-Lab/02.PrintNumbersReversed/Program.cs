using System;

namespace _02.PrintNumbersReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int count = int.Parse(Console.ReadLine());

            // Assign numbers to array:
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Print array reversed:
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
