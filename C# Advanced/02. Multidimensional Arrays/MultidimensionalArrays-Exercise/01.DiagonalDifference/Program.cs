using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine()); //square matrix size
        int[,] matrix = new int[matrixSize, matrixSize];
        BuildMatrix(matrix);

        // find sum of matrix left and right diagonals:
        int leftDiagonalSum = 0;
        int rightDiagonalSum = 0;

        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                if (row == col)
                {
                    rightDiagonalSum += matrix[row, col];
                }

                if (row + col == matrixSize - 1)
                {
                    leftDiagonalSum += matrix[row, col];
                }
            }
        }

        // print sums difference:
        Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
    }

    private static void BuildMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < colData.Length; col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}