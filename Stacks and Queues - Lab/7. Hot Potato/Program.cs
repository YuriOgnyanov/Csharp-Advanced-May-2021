using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> name = new Queue<string>(players);

            int iterations = int.Parse(Console.ReadLine());


            while (name.Count > 1)
            {
                for (int i = 1; i < iterations; i++)
                {
                    name.Enqueue(name.Dequeue());
                }
                Console.WriteLine($"Removed {name.Dequeue()}");
            }

            Console.WriteLine($"Last is {name.Peek()}");
        }
    }
}
