using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int number1 = 0;
            int number2 = 0;
            int countCombinations = 0;

            for (int i = startValue; i <= endValue; i++)
            {
                number1 = i;
                for (int j = startValue; j <= endValue; j++)
                {
                    number2 = j;
                    countCombinations++;

                    if (number1 + number2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{countCombinations} ({number1} + {number2} = {number1 + number2})");
                        break;
                    }
                }

                if (number1 + number2 == magicNumber)
                {
                    break;
                }
            }

            if (number1 + number2 != magicNumber)
            {
                Console.WriteLine($"{countCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
