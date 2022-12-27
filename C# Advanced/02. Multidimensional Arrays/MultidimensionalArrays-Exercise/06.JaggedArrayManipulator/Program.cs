using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedMatrix = new int[rows][];

        // build jagged matrix:
        for (int row = 0; row < rows; row++)
        {
            jaggedMatrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        // compare each 2 rows' lengths:
        for (int row = 0; row < rows - 1; row++)
        {
            if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
            {
                jaggedMatrix[row] = jaggedMatrix[row].Select(x => x * 2).ToArray();
                jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x * 2).ToArray();
            }
            else
            {
                jaggedMatrix[row] = jaggedMatrix[row].Select(x => x / 2).ToArray();
                jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x / 2).ToArray();
            }
        }

        // add and subtract value to a given position:
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandData = command.Split();
            int row = int.Parse(commandData[1]);
            int col = int.Parse(commandData[2]);
            int indexValue = int.Parse(commandData[3]);

            if (!(row >= 0 && row < rows && col >= 0 && col < jaggedMatrix[row].Length))
            {
                continue;
            }

            if (command.StartsWith("Add"))
            {
                jaggedMatrix[row][col] += indexValue;
            }
            else if (command.StartsWith("Subtract"))
            {
                jaggedMatrix[row][col] -= indexValue;
            }
        }

        // print jagged matrix:
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", jaggedMatrix[row]));
        }
    }
}