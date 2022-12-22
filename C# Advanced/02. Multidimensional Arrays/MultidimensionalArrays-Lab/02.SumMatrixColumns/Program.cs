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
            int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < currRow.Length; col++)
            {
                matrix[row, col] = currRow[col];
            }
        }

        // sum matrix columns:
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int columnSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                columnSum += matrix[row, col];
            }
            Console.WriteLine(columnSum);
        }
    }
}