using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadMatrixNumbers();

            string[,] matrix = new string[sizes[0], sizes[1]];

            string snake = Console.ReadLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //SoftUn
                //UtfoSi
                //niSoft
                //foSinU
                //tUniSo

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = snake[col].ToString();

                }



            }
        }
        private static int[] ReadMatrixNumbers()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
