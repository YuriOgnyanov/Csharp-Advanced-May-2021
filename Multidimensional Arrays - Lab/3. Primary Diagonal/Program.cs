using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you are given the integer N – the size of the square matrix
            int sizeForMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeForMatrix, sizeForMatrix];

            //The next N lines holds the values for every row – N numbers separated by a space
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currNumbers = ReadNumbersForCol();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currNumbers[col];
                }
            }

            //Sum Of matrix diagonal values
            int sumOfDiagonalMatrix = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumOfDiagonalMatrix +=  matrix[row, col];
                    row++;
                }
            }

            Console.WriteLine(sumOfDiagonalMatrix);
        }

        static int[] ReadNumbersForCol()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
