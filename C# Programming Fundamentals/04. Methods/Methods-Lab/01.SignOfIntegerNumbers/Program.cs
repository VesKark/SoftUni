using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Sign(input));
        }

		static string Sign(int input)
		{
			string result = "";
			if (input > 0)
			{
				result = "The number " + input + " is positive.";
			}
			else if (input < 0)
			{
				result = "The number " + input + " is negative.";
			}
			else
			{
				result = "The number " + input + " is zero.";
			}
			return result;
		}
	}
}
