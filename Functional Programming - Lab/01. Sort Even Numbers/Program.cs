using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.

            Func<string, int> parser = number => int.Parse(number);
            Func<int, bool> filter = number => number % 2 == 0;

            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Where(filter)
                .OrderBy(number => number)
                .ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
