using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            int digit = 0;
            int currentNumber = 0;

            for (int i = numA; i <= numB; i++)
            {
                currentNumber = i;
                for (int j = 6; j >= 1; j--)
                {
                    digit = currentNumber % 10;

                    if (j % 2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }

                    currentNumber = (currentNumber - digit) / 10;
                }

                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
                sumOdd = 0;
                sumEven = 0;
            }            
        }
    }
}
