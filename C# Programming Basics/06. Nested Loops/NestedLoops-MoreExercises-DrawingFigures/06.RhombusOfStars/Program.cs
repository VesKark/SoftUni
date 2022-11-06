using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());
            
            // Drawing upper part of rhombus:
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Drawing lower part of rhombus:
            for (int row = 1; row <= n - 1; row++)
            {
                for (int col = 1; col < row + 1; col++)
                {
                    Console.Write(" ");
                }
                for (int stars = n - row; stars >= 1; stars--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
