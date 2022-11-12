using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countChars = int.Parse(Console.ReadLine());

            // Estimating sum of ASCII codes of the chars:
            int sumCharCodes = 0;

            for (int i = 0; i < countChars; i++)
            {
                sumCharCodes += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sumCharCodes}");
        }
    }
}
