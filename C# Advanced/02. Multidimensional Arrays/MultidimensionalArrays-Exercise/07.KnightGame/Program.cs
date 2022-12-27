using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
   static int currentKnightEnemies;
    private static void Main(string[] args)
    {
        int boardSize = int.Parse(Console.ReadLine()); //chess board size
        char[,] chessBoard = new char[boardSize, boardSize];
        BuildMatrix(chessBoard);

        // count attacked knights:
        int countRemovedKnigths = 0;

        while (true)
        {
            currentKnightEnemies = 0;
            int maxAttacks = int.MinValue;
            int killerRow = 0;
            int killerCol = 0;

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (chessBoard[row, col] == 'K')
                    {
                        BordCells(chessBoard, row, col);

                        if (currentKnightEnemies > maxAttacks)
                        {
                            maxAttacks = currentKnightEnemies;
                            killerRow = row;
                            killerCol = col;
                        }

                        currentKnightEnemies = 0;
                    }
                }
            }

            if (maxAttacks > 0)
            {
                chessBoard[killerRow, killerCol] = '0';
                countRemovedKnigths++;
                continue;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(countRemovedKnigths);
    }

    private static void BordCells(char[,] chessBoard, int row, int col)
    {
        IsInside(chessBoard, row - 2, col - 1);
        IsInside(chessBoard, row - 2, col + 1);
        IsInside(chessBoard, row + 2, col - 1);
        IsInside(chessBoard, row + 2, col + 1);
        IsInside(chessBoard, row - 1, col - 2);
        IsInside(chessBoard, row - 1, col + 2);
        IsInside(chessBoard, row + 1, col - 2);
        IsInside(chessBoard, row + 1, col + 2);
    }

    public static void IsInside(char[,] chessBoard, int row, int col)
    {
        if (row >= 0 && row < chessBoard.GetLength(0) &&
               col >= 0 && col < chessBoard.GetLength(1)
               && chessBoard[row, col] == 'K')
        {
            currentKnightEnemies++;
        }
    }
    private static void BuildMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string colData = Console.ReadLine();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colData[col];
            }
        }
    }
}