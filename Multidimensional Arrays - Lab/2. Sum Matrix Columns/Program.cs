using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read matrix sizes.
            int[] sizes = ReadSizesForMatrix();

            int[,] matrix = new int[sizes[0], sizes[1]];

            //On the next row lines read the columns.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersForCol = ReadNumbersForCol();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersForCol[col];
                }
            }

            //Traverse the matrix and sum all elements in each column.

            int sumOfMatrix = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfMatrix += matrix[row, col];
                }

                //Print the sum and continue with the other columns.
                Console.WriteLine(sumOfMatrix);
                sumOfMatrix = 0;
            }
            
        }

        static int[] ReadSizesForMatrix() 
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
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
