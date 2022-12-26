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
        int[,] matrix = new int[rows, cols];
        BuildMatrix(matrix);

        // find 3x3-submatrix with max sum:
        // a b c
        // d e f
        // g h i

        int maxSum = int.MinValue;
        int topLeftRow = 0;
        int topLeftCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int a = matrix[row, col];
                int b = matrix[row, col + 1];
                int c = matrix[row, col + 2];
                int d = matrix[row + 1, col];
                int e = matrix[row + 1, col + 1];
                int f = matrix[row + 1, col + 2];
                int g = matrix[row + 2, col];
                int h = matrix[row + 2, col + 1];
                int i = matrix[row + 2, col + 2];

                int sum = a + b + c + d + e + f + g + h + i;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    topLeftRow = row;
                    topLeftCol = col;
                }
            }
        }

        // print result:
        Console.WriteLine($"Sum = {maxSum}");

        for (int row = topLeftRow; row < topLeftRow + 3; row++)
        {
            for (int col = topLeftCol; col < topLeftCol + 2; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }

            Console.WriteLine(matrix[row, topLeftCol + 2]);
        }
    }

    private static void BuildMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}