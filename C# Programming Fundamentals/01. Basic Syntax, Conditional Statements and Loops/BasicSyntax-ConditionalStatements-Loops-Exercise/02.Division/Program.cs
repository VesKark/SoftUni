using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int number = int.Parse(Console.ReadLine());
            bool isDivisible = false;
            int divider = 0;

            if (number % 10 == 0)
            {
                isDivisible = true;
                divider = 10;
            }
            else if (number % 7 == 0)
            {
                isDivisible = true;
                divider = 7;
            }
            else if (number % 6 == 0)
            {
                isDivisible = true;
                divider = 6;
            }
            else if (number % 3 == 0)
            {
                isDivisible = true;
                divider = 3;
            }
            else if (number % 2 == 0)
            {
                isDivisible = true;
                divider = 2;
            }

            // Output:
            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
