using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackOperations = new Stack<int>();

            //On the first line you will be given N, S and X, separated by a single space
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //N representing the number of elements to push into the stack
            int n = commands[0];
            //S representing the number of elements to pop from the stack
            int s = commands[1];
            //X, an element that you should look for in the stack
            int x = commands[2];

            //On the next line you will be given N number of integers
            int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < n; i++)
            {
                stackOperations.Push(numbers[i]);
            }

            //Here will pop S numbers from stack
            for (int i = 0; i < s; i++)
            {
                stackOperations.Pop();
                if (!stackOperations.Any())
                {
                    //If there are no elements in the sequence, print 0 on the console.
                    Console.WriteLine("0");
                    return;
                }
            }

            //If it’s found, print "true" on the console
            if (stackOperations.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                //If it isn't, print the smallest element currently present in the stack
                Console.WriteLine(stackOperations.Min());
            }

        }
    }
}
