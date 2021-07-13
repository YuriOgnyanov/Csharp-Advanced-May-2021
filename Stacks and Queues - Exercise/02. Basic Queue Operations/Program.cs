using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queueOperation = new Queue<int>();

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
                 queueOperation.Enqueue(numbers[i]);
            }

            //Here will pop S numbers from stack
            for (int i = 0; i < s; i++)
            {
                queueOperation.Dequeue();
                if (!queueOperation.Any())
                {
                    //If there are no elements in the sequence, print 0 on the console
                    Console.WriteLine("0");
                    return;
                }
            }

            //If it is, print true on the console
            if (queueOperation.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                //If it’s not print the smallest element currently present in the queue
                Console.WriteLine(queueOperation.Min());
            }


        }
    }
}
