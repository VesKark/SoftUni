using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			PrintMiddleChar(text);
		}

		static void PrintMiddleChar(string input)
		{
			char signA = input[input.Length / 2 - 1];
			char signB = input[input.Length / 2];

			if (input.Length % 2 != 0)
			{
				signA = '\0'; //empty char
			}
			Console.Write(signA);
			Console.WriteLine(signB);
		}
	}
}
