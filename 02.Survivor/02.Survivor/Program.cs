using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            char[][] jagedArray = new char[numRows][];

            for (int row = 0; row < numRows; row++)
            {
                char[] colData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < colData.Length; col++)
                {
                    jagedArray[row] = colData;
                }
            }

            string input = Console.ReadLine();

            int rowCommand = 0;
            int colCommand = 0;

            while (input != "Gong")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                ;
                switch (command)
                {
                    case "Find":
                        //Find {row} {col}
                        rowCommand = int.Parse(cmdArgs[1]);
                        colCommand = int.Parse(cmdArgs[2]);

                        for (int col = 0; col <= rowCommand; col++)
                        {
                            jagedArray[rowCommand][col] = '-';
                        }

                        break;

                    case "Opponent":
                        break;

                    default:
                        break;
                }



                input = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (var item in jagedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
