using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            long multiple = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(multiple);
        }

		static int GetMultipleOfEvenAndOdds(int result)
		{
			int evenSum = GetSumOfEvenDigits(result);
			int oddSum = GetSumOfOddDigits(result);
			return evenSum * oddSum;
		}

		static int GetSumOfEvenDigits(int number)
		{
			int evenSum = 0;
			while (number > 0)
			{
				int lastDigit = number % 10;
				if (lastDigit % 2 == 0)
				{
					evenSum += lastDigit;
				}
				number /= 10;
			}
			return evenSum;
		}

		static int GetSumOfOddDigits(int number)
		{
			int oddSum = 0;
			while (number > 0)
			{
				int lastDigit = number % 10;
				if (lastDigit % 2 != 0)
				{
					oddSum += lastDigit;
				}
				number /= 10;
			}
			return oddSum;
		}
	}
}
