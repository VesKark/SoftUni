using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
			string mathOperation = Console.ReadLine(); // "add", "multiply", "subtract" or "divide"
			int numA = int.Parse(Console.ReadLine());
			int numB = int.Parse(Console.ReadLine());

			switch (mathOperation)
			{
				case "add": Add(numA, numB); break;
				case "multiply": Multiply(numA, numB); break;
				case "subtract": Subtract(numA, numB); break;
				case "divide": Divide(numA, numB); break;
			}
		}

		static void Add(int a, int b)
		{
			int result = a + b;
			Console.WriteLine(result);
		}

		static void Multiply(int a, int b)
		{
			int result = a * b;
			Console.WriteLine(result);
		}

		static void Subtract(int a, int b)
		{
			int result = a - b;
			Console.WriteLine(result);
		}

		static void Divide(int a, int b)
		{
			int result = a / b;
			Console.WriteLine(result);
		}
	}
}
