using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());

            // Drawing first line of sunglasses:
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            // Drawing n-2 lines of sunglasses:
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');

                if (i + 1 != (n - 1) / 2)
                {
                    Console.Write(new string(' ', n));
                }
                else
                {
                    Console.Write(new string('|', n));
                }

                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine('*');
            }


            // Drawing last line of sunglasses:
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
