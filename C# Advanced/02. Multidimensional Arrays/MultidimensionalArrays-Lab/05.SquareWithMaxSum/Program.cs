using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];
        int[,] matrix = new int[rows, cols];

        // build matrix:
        for (int row = 0; row < rows; row++)
        {
            int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int col = 0; col < currRow.Length; col++)
            {
                matrix[row, col] = currRow[col];
            }
        }

        // find biggest 2x2-submatrix Sum:
        int sub = 2;
        int maxSum = int.MinValue;
        int topRow = 0;
        int topCol = 0;

        for (int row = 0; row <= rows - sub; row++)
        {
            for (int col = 0; col <= cols - sub; col++)
            {
                int currSum = 0;

                currSum += matrix[row, col];
                currSum += matrix[row, col + 1];
                currSum += matrix[row + 1, col];
                currSum += matrix[row + 1, col + 1];

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    topRow = row;
                    topCol = col;
                }
            }
        }

        // print submatrix and its Sum:
        Console.WriteLine(matrix[topRow, topCol] + " " + matrix[topRow, topCol + 1]);
        Console.WriteLine(matrix[topRow + 1, topCol] + " " + matrix[topRow + 1, topCol + 1]);
        Console.WriteLine(maxSum);
    }
}