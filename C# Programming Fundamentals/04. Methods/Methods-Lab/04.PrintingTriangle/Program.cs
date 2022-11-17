using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTriangle = int.Parse(Console.ReadLine());
            PrintTriangle(sizeOfTriangle);
        }

		static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		static void PrintTriangle(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				PrintLine(1, i);
			}
			for (int i = size - 1; i >= 1; i--)
			{
				PrintLine(1, i);
			}
		}
	}
}
