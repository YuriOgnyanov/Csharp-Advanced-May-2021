using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> output = new SortedSet<string>();

            //On the first line you will be given a number n - the count of input lines that you are going to receive.
            int nIterationsForRead = int.Parse(Console.ReadLine());

            //On the next n lines you will be receiving chemical compounds, separated by a single space.
            ReadStringAndAddInSet(output, nIterationsForRead);

            //Your task is to print all the unique ones in ascending order:
            Console.WriteLine(string.Join(" ", output));
        }

        private static void ReadStringAndAddInSet(SortedSet<string> output, int nIterationsForRead)
        {
            for (int i = 0; i < nIterationsForRead; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in text)
                {
                    output.Add(word);
                }

            }
        }
    }
}
