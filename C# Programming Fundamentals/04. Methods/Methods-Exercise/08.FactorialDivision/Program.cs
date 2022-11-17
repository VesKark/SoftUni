using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
			int numA = int.Parse(Console.ReadLine());
			int numB = int.Parse(Console.ReadLine());

			double result = Factorial(numA) * 1.00 / Factorial(numB);
			Console.WriteLine("{0:F2}", result);
		}

		static long Factorial(int number)
		{
			long factorialNum = 1;
			for (int i = 1; i <= number; i++)
			{
				factorialNum *= i;
			}
			return factorialNum;
		}
	}
}
