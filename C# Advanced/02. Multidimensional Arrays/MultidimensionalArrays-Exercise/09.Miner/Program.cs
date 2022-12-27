using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static int startRow;
    static int startCol;
    static int allCoals;

    private static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine()); //square matrix size
        char[,] matrix = new char[matrixSize, matrixSize];
        string[] directions = Console.ReadLine().Split();

        BuildMatrix(matrix);
        FindStartPosition(matrix);

        // follow directions:
        for (int i = 0; i < directions.Length; i++)
        {
            string direction = directions[i];
            FollowDirection(direction, matrixSize);

            if (matrix[startRow, startCol] == 'e')
            {
                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                return;
            }
            else if (matrix[startRow, startCol] ==  'c')
            {
                matrix[startRow, startCol] = '*';
                allCoals--;
            }

            if (allCoals == 0)
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                return;
            }
        }

        Console.WriteLine($"{allCoals} coals left. ({startRow}, {startCol})");
    }

    private static void FollowDirection(string direction, int matrixSize)
    {
        if (direction == "up" && startRow > 0)
        {
            startRow -= 1;
        }
        else if (direction == "down" && startRow < matrixSize - 1)
        {
            startRow += 1;
        }
        else if (direction == "left" && startCol > 0)
        {
            startCol -= 1;
        }
        else if (direction == "right" && startCol < matrixSize - 1)
        {
            startCol += 1;
        }
    }

    private static void FindStartPosition(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            bool startFound = false;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 's')
                {
                    startRow = row;
                    startCol = col;
                    startFound = true;
                    break;
                }
            }

            if (startFound)
            {
                break;
            }
        }
    }

    private static void BuildMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] colData = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];

                if (matrix[row, col] == 'c')
                {
                    allCoals++;
                }
            }
        }
    }
}