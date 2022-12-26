using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];
        char[,] matrix = new char[rows, cols];
        BuildMatrix(matrix);

        // find 2x2-submatrix with equal elements:
        // a b
        // c d

        int countEqual = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                char a = matrix[row, col];
                char b = matrix[row, col + 1];
                char c = matrix[row + 1, col];
                char d = matrix[row + 1, col + 1];

                if (a == b && a == c && c == d)
                {
                    countEqual++;
                }
            }
        }

        Console.WriteLine(countEqual);
    }

    private static void BuildMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] colData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}