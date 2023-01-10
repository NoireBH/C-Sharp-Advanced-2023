using System;
using System.Collections.Generic;

namespace _06._8_Queens_Puzzle
{
    public class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonal = new HashSet<int>();
        static void Main(string[] args)
        {
            bool[,] chessBoard = new bool[8, 8];
            PutQueens(chessBoard, 0);
        }

        private static void PutQueens(bool[,] chessBoard, int row)
        {

            if (row >= chessBoard.GetLength(0))
            {
                PrintChessBoard(chessBoard);
                return;
            }
            for (int col = 0; col < chessBoard.GetLength(1); col++)
            {
                if (CanPlaceQueen(row,col))
                {
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLeftDiagonal.Add(row - col);
                    attackedRightDiagonal.Add(row + col);
                    chessBoard[row, col] = true;
                    PutQueens(chessBoard, row + 1);

                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLeftDiagonal.Remove(row - col);
                    attackedRightDiagonal.Remove(row + col);
                    chessBoard[row, col] = false;
                }
            }
        }

        private static void PrintChessBoard(bool[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    if (chessBoard[row,col])
                    {
                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !attackedRows.Contains(row) && !attackedCols.Contains(col)
                && !attackedLeftDiagonal.Contains(row - col) && 
                !attackedRightDiagonal.Contains(row + col);
        }

    }
}
