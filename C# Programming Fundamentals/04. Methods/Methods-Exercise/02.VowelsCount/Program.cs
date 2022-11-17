using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			PrintVowelsConunt(text);
		}

		static void PrintVowelsConunt(string inputText)
		{
			char[] vowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
			int counterVowels = 0;

			for (int i = 0; i < inputText.Length; i++)
			{
				for (int j = 0; j < vowels.Length; j++)
				{
					if (inputText[i] == vowels[j])
					{
						counterVowels++;
					}
				}
			}
			Console.WriteLine(counterVowels);
		}
	}
}
