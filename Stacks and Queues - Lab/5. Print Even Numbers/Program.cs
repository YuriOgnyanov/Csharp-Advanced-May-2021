using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Queue<int> evenNumber = new Queue<int>(numbers);
            List<int> result = new List<int>();
            while (evenNumber.Count != 0)
            {
                int num = evenNumber.Peek();
                if (num % 2 != 0)
                {
                    evenNumber.Dequeue();
                }
                else
                {
                    result.Add(evenNumber.Dequeue());
                }

            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
