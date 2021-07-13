using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> firstSet = new HashSet<int>();

            HashSet<int> secondSet = new HashSet<int>();

            //On the first line you will receive two numbers - n and m, which represent the lengths of two separate sets
            int[] lengthsOfSet = ReadTwoLenghtsOfSet();

            //On the next n + m lines you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set
            ReadCurrentNumbersForSet(firstSet, secondSet, lengthsOfSet);

            //Find all the unique elements
            List<int> result = new List<int>();
            FindUniqueElementsAndPrint(firstSet, secondSet, result);

        }

        private static void FindUniqueElementsAndPrint(HashSet<int> firstSet, HashSet<int> secondSet, List<int> result)
        {
            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void ReadCurrentNumbersForSet(HashSet<int> firstSet, HashSet<int> secondSet, int[] lengthsOfSet)
        {
            for (int i = 0; i < lengthsOfSet[0] + lengthsOfSet[1]; i++)
            {
                int currNumbers = int.Parse(Console.ReadLine());

                if (i < lengthsOfSet[0])
                {
                    firstSet.Add(currNumbers);
                }
                else
                {
                    secondSet.Add(currNumbers);
                }
            }
        }

        private static int[] ReadTwoLenghtsOfSet()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
