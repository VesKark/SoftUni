using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());

            // Drawing christmas tree:
            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine();
            }
        }
    }
}
