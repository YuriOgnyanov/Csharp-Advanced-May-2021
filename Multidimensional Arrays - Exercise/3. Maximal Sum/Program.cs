using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns
            int[] sizes = ReadSizesPerRowAndCol();

            int[,] matrix = new int[sizes[0], sizes[1]];

            ReadMatrixColNumbers(matrix);

            int sumSquare = 0;

            int bestSquareInMatrix = int.MinValue;

            int rowIndex = 0;

            int colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                //4 5
                //1 5 5 2 4
                //2 1 4 14 3
                //3 7 11 2 8
                //4 8 12 16 4

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int firstColSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondColSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirdColSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    sumSquare = firstColSum + secondColSum + thirdColSum;

                    if (sumSquare > bestSquareInMatrix)
                    {
                        bestSquareInMatrix = sumSquare;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            PrintTheBestSquare(matrix, bestSquareInMatrix, rowIndex, colIndex);

        }

        private static void PrintTheBestSquare(int[,] matrix, int bestSquareInMatrix, int rowIndex, int colIndex)
        {
            Console.WriteLine($"Sum = {bestSquareInMatrix}");

            for (int row = rowIndex; row <= rowIndex + 2; row++)
            {
                for (int col = colIndex; col <= colIndex + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrixColNumbers(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] readNumberForCol = ReadSizesPerRowAndCol();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = readNumberForCol[col];
                }
            }
        }

        static int[] ReadSizesPerRowAndCol()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
