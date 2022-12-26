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

        string text = Console.ReadLine();
        Queue<char> snake = new Queue<char>(text);

        // add elements to the matrix:
        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = snake.Dequeue();
                    snake.Enqueue(matrix[row, col]);
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake.Dequeue();
                    snake.Enqueue(matrix[row, col]);
                }
            }
        }

        // print the matrix:
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}