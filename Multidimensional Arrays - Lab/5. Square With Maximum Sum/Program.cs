using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var row = rowAndCol[0];
            var col = rowAndCol[1];

            int[,] matrix = new int[row, col];

            int maxSumSquere = int.MinValue;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }

            List<int> maxSquere = new List<int>();

            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourNumber = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {

                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    int sum = 0;
                    sum += matrix[r, c];
                    sum += matrix[r, c + 1];
                    sum += matrix[r + 1, c];
                    sum += matrix[r + 1, c + 1];

                    if (sum > maxSumSquere)
                    {
                        maxSumSquere = sum;
                        firstNumber = matrix[r, c];
                        secondNumber = matrix[r, c + 1];
                        thirdNumber = matrix[r + 1, c];
                        fourNumber = matrix[r + 1, c + 1];
                    }

                }
            }

            Console.WriteLine(firstNumber + " " + secondNumber);
            Console.WriteLine(thirdNumber + " " + fourNumber);
            Console.WriteLine(maxSumSquere);

        }
    }
}
