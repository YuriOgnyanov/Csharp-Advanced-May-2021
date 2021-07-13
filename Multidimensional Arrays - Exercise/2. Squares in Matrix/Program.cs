using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the count of 2 x 2 squares of equal chars in a matrix.


            //On the first line, you are given the integers rows and cols – the matrix’s dimensions
            int[] sizes = ReadSizesPerRowAndCol();

            char[,] matrix = new char[sizes[0], sizes[1]];

            ReadCharactersForCol(matrix);

            int counter = 0;

            counter = CheckFor2x2SquaresOfMatrix(matrix, counter);

            Console.WriteLine(counter);
        }

        private static int CheckFor2x2SquaresOfMatrix(char[,] matrix, int counter)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        private static void ReadCharactersForCol(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Matrix characters come at the next rows lines (space separated)
                char[] readCharactersForCol = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = readCharactersForCol[col];
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
