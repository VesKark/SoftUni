using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine()); //Pascal’s triangle size [1 to 60]

        long[][] triangle = new long[size][];

        // build Pascal’s triangle
        triangle[0] = new long[] { 1 }; //build first row

        for (int row = 1; row < size; row++)
        {
            long[] currRow = new long[row + 1];
            currRow[0] = 1;

            for (int col = 1; col <= row - 1; col++)
            {
                currRow[col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }

            currRow[row] = 1;
            triangle[row] = currRow;
        }

        // print Pascal’s triangle
        foreach (var row in triangle)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}