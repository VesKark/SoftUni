using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
			int numA = int.Parse(Console.ReadLine());
			int numB = int.Parse(Console.ReadLine());
			int numC = int.Parse(Console.ReadLine());

			int sum = Sum(numA, numB);
			int result = Subtract(sum, numC);
			Console.WriteLine(result);
		}

		static int Sum(int a, int b)
		{
			return a + b;
		}

		static int Subtract(int a, int b)
		{
			return a - b;
		}
	}
}
