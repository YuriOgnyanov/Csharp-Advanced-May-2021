using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you are given the integer N – the size of the square matrix
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(size, size);

            int primaryDiagonal = 0;
            primaryDiagonal = SumPrimaryDiagonal(matrix, primaryDiagonal);

            int secondaryDiagonal = 0;
            secondaryDiagonal = SumSecondaryDiagonal(matrix, secondaryDiagonal);

            PrintTheAbsoluteResult(primaryDiagonal,secondaryDiagonal);
        }

         static void PrintTheAbsoluteResult(int primaryDiagonal, int secondaryDiagonal)
        {
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }

        static int SumSecondaryDiagonal(int[,] matrix, int secondaryDiagonal)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    secondaryDiagonal += matrix[row, matrix.GetLength(0) - row - 1];
                    row++;
                }
            }

            return secondaryDiagonal;
        }

        static int SumPrimaryDiagonal(int[,] matrix, int primaryDiagonal)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    primaryDiagonal += matrix[row, col];
                    row++;
                }
            }

            return primaryDiagonal;
        }

        //The next N lines holds the values for every row – N numbers separated by a space
        static int[,] ReadMatrix(int rows,int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currNumbers = ReadValuesForEveryRow();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currNumbers[col];
                }
            }
            return matrix;
        }

        static int[] ReadValuesForEveryRow() 
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

    }
}
