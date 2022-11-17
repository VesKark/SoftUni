using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
			string valueType = Console.ReadLine(); // "int", "char" or "string"
			string valueOne = Console.ReadLine();
			string valueTwo = Console.ReadLine();

			if (valueType == "int")
			{
				int firstNum = int.Parse(valueOne);
				int secondNum = int.Parse(valueTwo);
				Console.WriteLine(GetMax(firstNum, secondNum));
			}
			else if (valueType == "char")
			{
				char firstNum = char.Parse(valueOne);
				char secondNum = char.Parse(valueTwo);
				Console.WriteLine(GetMax(firstNum, secondNum));
			}
			else if (valueType == "string")
			{
				Console.WriteLine(GetMax(valueOne, valueTwo));
			}
		}

		static int GetMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		static char GetMax(char a, char b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		static string GetMax(string a, string b)
		{
			int sumA = a.CompareTo(b);
			if (sumA >= 0)
			{
				return a;
			}
			return b;
		}
	}
}
