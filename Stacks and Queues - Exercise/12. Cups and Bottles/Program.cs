using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of input you will receive the integers, representing the cups' capacity, separated by a single space.
            int[] cups = ReadNumbersFromConsole();
            //On the second line of input you will receive the integers, representing the filled bottles, separated by a single space.
            int[] bottles = ReadNumbersFromConsole();

            Queue<int> cupsCapacity = new Queue<int>(cups);

            Stack<int> filledBottles = new Stack<int>(bottles);

            int wastedLittersOfWater = 0;

            while (cupsCapacity.Any() && filledBottles.Any())
            {
                

                if (filledBottles.Peek() >= cupsCapacity.Peek())
                {
                    int subtraction = filledBottles.Peek() - cupsCapacity.Peek();
                    cupsCapacity.Dequeue();
                    filledBottles.Pop();
                    wastedLittersOfWater += subtraction;
                }
                else
                {
                    int currCups = cupsCapacity.Peek();
                    while (currCups > 0)
                    {
                        currCups -= filledBottles.Peek();
                        if (currCups <= 0)
                        {
                            wastedLittersOfWater += Math.Abs(currCups);
                        }
                        else
                        {
                            filledBottles.Pop();
                        }
                    }

                    cupsCapacity.Dequeue();
                    filledBottles.Pop();
                }

            }

            //Print the Results
            if (cupsCapacity.Any() && !filledBottles.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
                Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
            }

            if (filledBottles.Any() && !cupsCapacity.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", filledBottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
            }
        }
        //Method For Read Integer                                
        static int[] ReadNumbersFromConsole() 
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

    }
}
