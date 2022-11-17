using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
			char charStart = char.Parse(Console.ReadLine());
			char charEnd = char.Parse(Console.ReadLine());

			if (charStart > charEnd)
			{
				char temp = charEnd;
				charEnd = charStart;
				charStart = temp;
			}

			PrintCharRange(charStart, charEnd);
		}

		static void PrintCharRange(char start, char end)
		{
			for (int i = start + 1; i < end; i++)
			{
				Console.Write((char)i + " ");
			}
		}
	}
}
