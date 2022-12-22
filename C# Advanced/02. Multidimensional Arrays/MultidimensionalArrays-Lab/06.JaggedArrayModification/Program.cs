using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        // build jagged array:
        int[][] jaggedArray = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            int[] colValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            jaggedArray[row] = colValues;
        }

        // operate with jagged array:
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] coordinates = command.Split();
            string action = coordinates[0];
            int currRow = int.Parse(coordinates[1]);
            int currCol = int.Parse(coordinates[2]);
            int inputValue = int.Parse(coordinates[3]);

            // check if coordinates are valid:
            bool validRow = currRow >= 0 && currRow < rows;
            if (!validRow)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            bool validCol = currCol >= 0 && currCol < jaggedArray[currRow].Length;
            if (!validCol)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            // add or subtract values in the matrix:
            if (action == "Add")
            {
                jaggedArray[currRow][currCol] += inputValue;
            }
            else if (action == "Subtract")
            {
                jaggedArray[currRow][currCol] -= inputValue;
            }
        }

        // print jagged array:
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", jaggedArray[row]));
        }
    }
}