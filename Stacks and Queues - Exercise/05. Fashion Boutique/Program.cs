using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line you will be given a sequence of integers, representing the clothes in the box, separated by a single space
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(numbers);

            //On the second line, you will be given an integer, representing the capacity of a rack
            int capacity = int.Parse(Console.ReadLine());

            //While the sum of the clothes is less than the capacity, keep summing them

            int counter = 0;
            int sum = 0;

            while (clothes.Any())
            {
                //If there are any left in the box
                if (sum + clothes.Peek() <= capacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    counter++;
                    sum = 0;
                }

            }
            counter++;
            Console.WriteLine(counter);
        }
    }
}
