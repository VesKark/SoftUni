using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); //square matrix size
        int[,] matrix = new int[n, n];

        // build matrix:        
        for (int row = 0; row < n; row++)
        {
            int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = currRow[col];
            }
        }

        // estimate diagonal sum:
        int diagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            diagonalSum += matrix[i, i];
        }

        Console.WriteLine(diagonalSum);
    }
}