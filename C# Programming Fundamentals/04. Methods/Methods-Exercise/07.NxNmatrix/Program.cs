using System;

namespace _07.NxNmatrix
{
    class Program
    {
        static void Main(string[] args)
        {
			int sizeOfMatrix = int.Parse(Console.ReadLine());
			PrintMatrix(sizeOfMatrix);
		}

		static void PrintMatrix(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write(size + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
