using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
			int inputNum = int.Parse(Console.ReadLine());

			for (int i = 17; i <= inputNum; i++)
			{
				if (CheckIfTop(i))
				{
					Console.WriteLine(i);
				}
			}
		}

		static bool CheckIfTop(int number)
		{
			bool isTop = false;
			bool containsOdd = false;
			int sum = 0;

			while (number > 0)
			{
				int lastDigit = number % 10;
				sum += lastDigit;

				if (lastDigit % 2 != 0)
				{
					containsOdd = true;
				}

				number /= 10;
			}

			if (sum % 8 == 0 && containsOdd)
			{
				isTop = true;
			}

			return isTop;
		}
	}
}
