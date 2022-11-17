using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();

			while (input != "END")
			{
				int number = int.Parse(input);
				Console.WriteLine(CheckIfPalindrome(number).ToString().ToLower());

				input = Console.ReadLine();
			}
		}

		static bool CheckIfPalindrome(int number)
		{
			int[] numberArray = number.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
			Array.Reverse(numberArray);
			int numberReversed = int.Parse(string.Join("", numberArray));
			bool isPalindrome = number == numberReversed;
			return isPalindrome;
		}
	}
}
