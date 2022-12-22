using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine()); //square matrix size
        char[,] matrix = new char[size, size];

        //build matrix:
        for (int row = 0; row < size; row++)
        {
            string chars = Console.ReadLine();

            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = chars[col];
            }
        }

        // find symbol in the matrix:
        char findSymbol = char.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row, col] == findSymbol)
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
            }
        }
        
        Console.WriteLine($"{findSymbol} does not occur in the matrix");        
    }
}