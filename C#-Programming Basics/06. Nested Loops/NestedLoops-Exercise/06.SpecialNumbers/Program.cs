using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int currentNumber = 0;
            int count = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                currentNumber = i;
                for (int j = 4; j >= 1; j--)
                {
                    if (j > 1)
                    {
                        digit = currentNumber % 10;
                    }
                    else
                    {
                        digit = currentNumber;
                    }

                    if (digit != 0 && number % digit == 0)
                    {
                        count++;
                    }
                    currentNumber = (currentNumber - digit) / 10;
                }

                if (count == 4)
                {
                    Console.Write(i + " ");
                }
                count = 0;
            }
        }
    }
}
