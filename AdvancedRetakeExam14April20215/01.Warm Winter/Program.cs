using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            //First you will be given a sequence of integers representing the hats. 
            int[] hats = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Afterwards you will be given another sequence of integers representing the scarfs. 
            int[] scarfs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //StackHats
            Stack<int> stackHats = new Stack<int>(hats);

            //QueueScraft
            Queue<int> queueScraft = new Queue<int>(scarfs);

            List<int> complete = new List<int>();


            while (stackHats.Any() && queueScraft.Any())
            {
                if (stackHats.Peek() > queueScraft.Peek())
                {
                    complete.Add(stackHats.Pop() + queueScraft.Dequeue());
                }
                else if (stackHats.Peek() == queueScraft.Peek())
                {
                    queueScraft.Dequeue();
                    stackHats.Push(stackHats.Pop() + 1);
                }
                else if (stackHats.Peek() < queueScraft.Peek())
                {
                    stackHats.Pop();
                }
            }

            Console.WriteLine($"The most expensive set is: {complete.Max()}");
            Console.WriteLine(string.Join(" ", complete));
        }
    }
}
