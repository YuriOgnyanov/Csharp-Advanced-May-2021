using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive the number of rows of the matrix - integer N
            int rowsOfTheMatrix = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[rowsOfTheMatrix][];

            

            //Then, you will receive commands. There are three possible commands:

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                int row = 0;
                int column = 0;
                int value = 0;

                switch (cmdArgs[0])
                {
                    //"Add {row} {column} {value}" - add {value} to the element at the given indexes, if they are valid
                    case "Add":
                        row = int.Parse(cmdArgs[1]);
                        column = int.Parse(cmdArgs[2]);
                        value = int.Parse(cmdArgs[3]);

                        if (row >= 0 && row <= jaggedArr.GetLength(0) && column >= 0 && column <= jaggedArr[row].Length)
                        {
                            jaggedArr[row][column] += value;
                        }

                        break;
                    //"Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid
                    case "Subtract":
                        row = int.Parse(cmdArgs[1]);
                        column = int.Parse(cmdArgs[2]);
                        value = int.Parse(cmdArgs[3]);

                        if (row >= 0 && row <= jaggedArr.GetLength(0) && column >= 0 && column <= jaggedArr[row].Length)
                        {
                            jaggedArr[row][column] -= value;
                        }

                        break;

                }

                input = Console.ReadLine();
            }

            //The output should be printed on the console and it should consist of N lines
            //Each line should contain a string representing the respective row of the final matrix, elements separated by a single space
            PrintTheResultJaggetArr(jaggedArr);

        }

        private static void PrintTheResultJaggetArr(int[][] jaggedArr)
        {
            foreach (var numbers in jaggedArr)
            {
                Console.WriteLine($"{string.Join(" ", numbers)}");
            }
        }

        static void ReadNumbersForEachCol(int[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.GetLength(0); row++)
            {
                int[] numbersForCols = ReadNumbersForCol();

                for (int col = 0; col < numbersForCols.Length; col++)
                {
                    jaggedArr[row] = numbersForCols;
                }
            }
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
