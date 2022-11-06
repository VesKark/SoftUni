using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());

            // Drawing first half of diamond:
            int rowsInHalf = (n + 1) / 2;

            // (a) Drawing Line 1:
            Console.Write(new string('-', rowsInHalf - 1));
            if (n % 2 == 0)
            {
                Console.Write("**");
            }
            else
            {
                Console.Write("*");
            }
            Console.WriteLine(new string('-', rowsInHalf - 1));


            // (b) Drawing Line 2 to (n + 1) / 2:
            for (int row = 2; row <= rowsInHalf; row++)
            {
                Console.Write(new string('-', rowsInHalf - row));
                Console.Write('*');
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', 2 * row - 2));
                }
                else
                {
                    Console.Write(new string('-', 2 * row - 3));
                }
                Console.Write('*');
                Console.WriteLine(new string('-', rowsInHalf - row));
            }


            // Drawing second half of diamond:

            // (a) Drawing Lines to (n - 1) / 2:
            for (int row = rowsInHalf - 1; row >= 2; row--)
            {
                Console.Write(new string('-', rowsInHalf - row));
                Console.Write('*');
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', 2 * row - 2));
                }
                else
                {
                    Console.Write(new string('-', 2 * row - 3));
                }
                Console.Write('*');
                Console.WriteLine(new string('-', rowsInHalf - row));
            }

            // (b) Drawing Line n:
            if (n > 2)
            {
                Console.Write(new string('-', rowsInHalf - 1));
                if (n % 2 == 0)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', rowsInHalf - 1));
            }            
        }
    }
}
