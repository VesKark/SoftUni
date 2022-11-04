using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int isStrong = input;
            int sumFactorial = 0;

            while (input > 0)
            {
                int lastDigit = input % 10;

                int factorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                sumFactorial += factorial;
                factorial = 1;
                input /= 10;
            }

            // Output:
            if (isStrong == sumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
