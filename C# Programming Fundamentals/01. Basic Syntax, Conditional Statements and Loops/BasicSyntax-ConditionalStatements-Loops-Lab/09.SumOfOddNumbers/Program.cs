using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countOdd = int.Parse(Console.ReadLine());
            int sumOdd = 0;

            // Output odd numbers and their sum:
            for (int i = 1; i <= 2 * countOdd; i += 2)
            {
                Console.WriteLine(i);
                sumOdd += i;
            }
            Console.WriteLine($"Sum: {sumOdd}");
        }
    }
}
