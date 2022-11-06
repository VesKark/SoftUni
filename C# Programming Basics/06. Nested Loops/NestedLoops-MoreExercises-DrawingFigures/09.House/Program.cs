using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());

            // Drawing roof:
            int roofRows = (n + 1) / 2 - 1;

            for (int row = 1; row <= roofRows; row++)
            {
                if (n % 2 != 0)
                {
                    Console.Write(new string('-', roofRows + 1 - row));
                    Console.Write(new string('*', 2 * row - 1));
                    Console.WriteLine(new string('-', roofRows + 1 - row));
                }
                else
                {
                    Console.Write(new string('-', roofRows + 1 - row));
                    Console.Write(new string('*', 2 * row));
                    Console.WriteLine(new string('-', roofRows + 1 - row));
                }
            }

            // Drawing roof gutter:
            Console.WriteLine(new string('*', n));

            // Drawing walls:
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
