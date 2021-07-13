using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Reads an input of integer numbers and adds them to a stack
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersInStack = new Stack<int>(numbers.Length - 1);

            foreach (var num in numbers)
            {
                numbersInStack.Push(num);
            }
            //•	Reads commands until "end" is received
            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0].ToUpper();

                if (command == "END")
                {
                    break;
                }

                if (command == "ADD")
                {
                    int firstNumber = int.Parse(cmdArgs[1]);
                    int secondNumber = int.Parse(cmdArgs[2]);
                    numbersInStack.Push(firstNumber);
                    numbersInStack.Push(secondNumber);
                }
                else if (command == "REMOVE")
                {
                    int removeNumber = int.Parse(cmdArgs[1]);
                    if (numbersInStack.Count >= removeNumber)
                    {
                        for (int i = 0; i < removeNumber; i++)
                        {
                            numbersInStack.Pop();
                        }
                    }
                }

            }
            //•	Prints the sum of the remaining elements of the stack
            Console.WriteLine($"Sum: {numbersInStack.Sum()}");
        }
    }
}
