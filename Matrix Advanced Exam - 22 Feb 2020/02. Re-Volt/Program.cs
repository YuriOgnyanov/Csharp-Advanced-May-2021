using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you are given the integer N – the size of the square matrix.
            int sizesMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizesMatrix, sizesMatrix];


            //The next N lines holds the values for every row.
            ReadValuesForCol(matrix);

            int foodCounter = 0;



            string command = Console.ReadLine();
            //"up", "down", "left", "right".

            while (foodCounter < 10)
            {
                bool IsValid = false;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'S')
                        {
                            switch (command)
                            {
                                case "up":

                                    if (row - 1 < 0)
                                    {
                                        matrix[row, col] = '.';
                                        GameOverPrint(matrix, foodCounter);
                                        return;
                                    }
                                    else
                                    {
                                        if (matrix[row - 1, col] == '*')
                                        {
                                            matrix[row - 1, col] = 'S';
                                            foodCounter++;
                                            matrix[row, col] = '.';
                                        }
                                        else if (matrix[row - 1, col] == 'B')
                                        {
                                            matrix[row - 1, col] = '.';
                                            matrix[row, col] = '.';

                                            SearchBsymbol(matrix);
                                        }
                                        else if (matrix[row - 1, col] == '-')
                                        {
                                            matrix[row - 1, col] = 'S';
                                            matrix[row, col] = '.';
                                        }
                                    }

                                    IsValid = true;

                                    break;

                                case "down":

                                    if (row + 1 > matrix.GetLength(0) - 1)
                                    {
                                        matrix[row, col] = '.';
                                        GameOverPrint(matrix, foodCounter);
                                        return;
                                    }
                                    else
                                    {
                                        if (matrix[row + 1, col] == '*')
                                        {
                                            matrix[row + 1, col] = 'S';
                                            foodCounter++;
                                            matrix[row, col] = '.';
                                        }
                                        else if (matrix[row + 1, col] == 'B')
                                        {
                                            matrix[row + 1, col] = '.';
                                            matrix[row, col] = '.';

                                            SearchBsymbol(matrix);
                                        }
                                        else if (matrix[row + 1, col] == '-')
                                        {
                                            matrix[row + 1, col] = 'S';
                                            matrix[row, col] = '.';
                                        }
                                    }

                                    IsValid = true;

                                    break;

                                case "left":

                                    if (col - 1 < 0)
                                    {
                                        matrix[row, col] = '.';
                                        GameOverPrint(matrix, foodCounter);
                                        return;
                                    }
                                    else
                                    {
                                        if (matrix[row, col - 1] == '*')
                                        {
                                            matrix[row, col - 1] = 'S';
                                            foodCounter++;
                                            matrix[row, col] = '.';
                                        }
                                        else if (matrix[row, col - 1] == 'B')
                                        {
                                            matrix[row, col - 1] = '.';
                                            matrix[row, col] = '.';

                                            SearchBsymbol(matrix);
                                        }
                                        else if (matrix[row, col - 1] == '-')
                                        {
                                            matrix[row, col - 1] = 'S';
                                            matrix[row, col] = '.';
                                        }
                                    }

                                    IsValid = true;
                                    break;

                                case "right":

                                    if (col + 1 > matrix.GetLength(1) - 1)
                                    {
                                        matrix[row, col] = '.';
                                        GameOverPrint(matrix, foodCounter);
                                        return;
                                    }
                                    else
                                    {
                                        if (matrix[row, col + 1] == '*')
                                        {
                                            matrix[row, col + 1] = 'S';
                                            foodCounter++;
                                            matrix[row, col] = '.';
                                        }
                                        else if (matrix[row, col + 1] == 'B')
                                        {
                                            matrix[row, col + 1] = '.';
                                            matrix[row, col] = '.';

                                            SearchBsymbol(matrix);
                                        }
                                        else if (matrix[row, col + 1] == '-')
                                        {
                                            matrix[row, col + 1] = 'S';
                                            matrix[row, col] = '.';
                                        }
                                    }

                                    IsValid = true;
                                    break;
                            }

                            break;

                        }
                    }

                    if (IsValid)
                    {
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("You won! You fed the snake.");
            Console.WriteLine($"Food eaten: {foodCounter}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
       
        //Here Print The result of GameOver
        private static void GameOverPrint(char[,] matrix, int foodCounter)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine($"Food eaten: {foodCounter}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            return;

        }
        //Search "B" Symbol
        private static void SearchBsymbol(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        matrix[row, col] = 'S';
                    }
                }
            }
        }
        //ReadValueForCols
        static void ReadValuesForCol(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] valuesCol = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = valuesCol[col];
                }
            }
        }
    }
}
