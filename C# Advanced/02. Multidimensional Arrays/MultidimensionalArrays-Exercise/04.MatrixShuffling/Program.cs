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
        string[,] matrix = new string[rows, cols];
        BuildMatrix(matrix);

        // execute operations:
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (command.StartsWith("swap") && commandInfo.Length == 5)
            {
                int row1 = int.Parse(commandInfo[1]);
                int col1 = int.Parse(commandInfo[2]);
                int row2 = int.Parse(commandInfo[3]);
                int col2 = int.Parse(commandInfo[4]);

                // check if coordinates are valid:
                if (!CheckIndex(row1, col1, rows, cols) || !CheckIndex(row2, col2, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }                

                // swap element positions:
                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    private static bool CheckIndex(int row1, int col1, int rows, int cols)
    {
        if (row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols)
        {
            return true;
        }
        return false;
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void BuildMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] colData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}