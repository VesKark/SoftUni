using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static int bunnyRow;
    static int bunnyCol;

    private static void Main(string[] args)
    {
        int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];
        char[,] matrix = new char[rows, cols];

        BuildMatrix(matrix);
        FindBunnyPosition(matrix);
        matrix[bunnyRow, bunnyCol] = '.';

        // move bunny in the matrix:
        char[] commands = Console.ReadLine().ToCharArray();

        for (int i = 0; i < commands.Length; i++)
        {
            char command = commands[i];
            bool movePlayer = FollowDirection(command, matrix);

            // save bunny positions:
            char[,] bunnyMatrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bunnyMatrix[row, col] = matrix[row, col];
                }
            }
            MoveBunnies(matrix, bunnyMatrix);

            if (movePlayer)
            {
                PrintMatrix(matrix);
                Console.WriteLine($"won: {bunnyRow} {bunnyCol}");
                return;
            }

            if (matrix[bunnyRow, bunnyCol] == 'B')
            {
                PrintMatrix(matrix);
                Console.WriteLine($"dead: {bunnyRow} {bunnyCol}");
                return;
            }           
        }

        PrintMatrix(matrix);
        Console.WriteLine($"won: {bunnyRow} {bunnyCol}");
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void MoveBunnies(char[,] matrix, char[,] bunnyMatrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {                
                if (bunnyMatrix[row, col] == 'B')
                {
                    if (row - 1 >= 0)
                    {
                        matrix[row - 1, col] = 'B';
                    }

                    if (col - 1 >= 0)
                    {
                        matrix[row, col - 1] = 'B';
                    }

                    if (row + 1 < matrix.GetLength(0))
                    {
                        matrix[row + 1, col] = 'B';
                    }

                    if (col + 1 < matrix.GetLength(1))
                    {
                        matrix[row, col + 1] = 'B';
                    }
                }
            }
        }
    }

    private static bool FollowDirection(char direction, char[,] matrix)
    {
        if (direction == 'U')
        {
            bunnyRow -= 1;
            if (bunnyRow < 0)
            {
                bunnyRow = 0;
                return true;
            }
        }
        else if (direction == 'D')
        {
            bunnyRow += 1;
            if (bunnyRow >= matrix.GetLength(0))
            {
                bunnyRow = matrix.GetLength(0) - 1;
                return true;
            }
        }
        else if (direction == 'L')
        {
            bunnyCol -= 1;
            if (bunnyCol < 0)
            {
                bunnyCol = 0;
                return true;
            }
        }
        else if (direction == 'R')
        {
            bunnyCol += 1;
            if (bunnyCol >= matrix.GetLength(1))
            {
                bunnyCol = matrix.GetLength(1) - 1;
                return true;
            }
        }

        return false;        
    }

    private static void FindBunnyPosition(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            bool bunnyFound = false;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 'P')
                {
                    bunnyRow = row;
                    bunnyCol = col;
                    bunnyFound = true;
                    break;
                }
            }

            if (bunnyFound)
            {
                break;
            }
        }
    }

    private static void BuildMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] colData = Console.ReadLine().ToCharArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}