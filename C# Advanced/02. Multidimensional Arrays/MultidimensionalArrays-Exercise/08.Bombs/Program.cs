using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static int matrixSize = int.Parse(Console.ReadLine()); //square matrix size
    static int[,] matrix = new int[matrixSize, matrixSize];
    private static void Main(string[] args)
    {
        BuildMatrix(matrix);

        int[] indexes = Console.ReadLine().Split(new Char[] { ',', ' ' }).Select(int.Parse).ToArray();
        
        // explode bombs:
        for (int i = 0; i < indexes.Length; i += 2)
        {
            int row = indexes[i];
            int col = indexes[i + 1];

            if (matrix[row, col] <= 0)
            {
                continue;
            }

            ExplodeCells(row, col);
        }

        // find alive cells and their sum:
        int countAliveCells = 0;
        int sumAliveCells = 0;

        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                if (matrix[row, col] > 0)
                {
                    countAliveCells++;
                    sumAliveCells += matrix[row, col];
                }
            }
        }

        // print result:
        Console.WriteLine($"Alive cells: {countAliveCells}");
        Console.WriteLine($"Sum: {sumAliveCells}");

        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void ExplodeCells(int row, int col)
    {
        int bombValue = matrix[row, col];
        matrix[row, col] -= bombValue;

        CheckCell(row - 1, col - 1, bombValue);
        CheckCell(row - 1, col, bombValue);
        CheckCell(row - 1, col + 1, bombValue);
        CheckCell(row, col - 1, bombValue);
        CheckCell(row, col + 1, bombValue);
        CheckCell(row + 1, col - 1, bombValue);
        CheckCell(row + 1, col, bombValue);
        CheckCell(row + 1, col + 1, bombValue);
    }

    private static void CheckCell(int row, int col, int bombValue)
    {
        if (row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
        {
            if (matrix[row, col] > 0)
            {
                matrix[row, col] -= bombValue;
            }
        }
    }

    private static void BuildMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}