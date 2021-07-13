using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNumbers = new Stack<int>();

            //The first line of input contains an integer, N
            int nIterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < nIterations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    //1 x – Push the element x into the stack.
                    case "1":
                        stackNumbers.Push(int.Parse(cmdArgs[1]));
                        break;

                    //2 – Delete the element present at the top of the stack.
                    case "2":
                        if (stackNumbers.Any())
                        {
                            stackNumbers.Pop();
                        }
                        break;

                    //3 – Print the maximum element in the stack.
                    case "3":
                        if (stackNumbers.Any())
                        {
                            Console.WriteLine(stackNumbers.Max());
                        }
                        break;

                    //4 – Print the minimum element in the stack.
                    case "4":
                        if (stackNumbers.Any())
                        {
                            Console.WriteLine(stackNumbers.Min());
                        }
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

            //After you go through all of the queries, print the stack
            Console.WriteLine(string.Join(", ", stackNumbers));
        }
    }
}
