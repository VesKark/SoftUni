using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine()); // "/", "*", "+" or "-"
            double numB = double.Parse(Console.ReadLine());

            Calculation(numA, mathOperator, numB);
        }

		static void Calculation(double a, char math, double b)
		{
			double result = 0;

			if (math == '/')
			{
				result = a / b;
			}
			else if (math == '*')
			{
				result = a * b;
			}
			else if (math == '+')
			{
				result = a + b;
			}
			else if (math == '-')
			{
				result = a - b;
			}

			Console.WriteLine(result);
		}
	}
}
