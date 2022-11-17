using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
			string password = Console.ReadLine();
			bool length = CheckLength(password);
			bool chars = CheckChars(password);
			bool digits = CheckDigitsCount(password);
			bool passwordIsValid = length && chars && digits;

			if (passwordIsValid)
			{
				Console.WriteLine("Password is valid");
			}
			else
			{
				if (!length)
				{
					Console.WriteLine("Password must be between 6 and 10 characters");
				}
				if (!chars)
				{
					Console.WriteLine("Password must consist only of letters and digits");
				}
				if (!digits)
				{
					Console.WriteLine("Password must have at least 2 digits");
				}
			}
		}

		static bool CheckLength(string password)
		{
			bool validLength = password.Length >= 6 && password.Length <= 10;
			return validLength;
		}

		static bool CheckChars(string password)
		{
			bool validChars = password.All(Char.IsLetterOrDigit);
			return validChars;
		}

		static bool CheckDigitsCount(string password)
		{
			bool valiDigitCount = password.Count(Char.IsDigit) >= 2;
			return valiDigitCount;
		}
	}
}
