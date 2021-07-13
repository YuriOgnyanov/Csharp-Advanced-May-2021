using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read sizes for matrix integer N number
            int sizes = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizes, sizes];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }

            //Read Special Symbol And Search
            char specialSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == specialSymbol)
                    {
                        //if the find the special symbol, print the Results
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{specialSymbol} does not occur in the matrix ");
        }
    }
}
