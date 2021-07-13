using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = ReadNumbersFromConsole();

            Dictionary<double, int> valuesTime = new Dictionary<double, int>();

            FindTheNumbersInDictionary(numbers, valuesTime);

            PrintTheValuesTimes(valuesTime);
        }

        private static void FindTheNumbersInDictionary(double[] numbers, Dictionary<double, int> valuesTime)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (valuesTime.ContainsKey(numbers[i]))
                {
                    valuesTime[numbers[i]]++;
                }
                else
                {
                    valuesTime.Add(numbers[i], 1);
                }
            }
        }

        private static void PrintTheValuesTimes(Dictionary<double, int> valuesTime)
        {
            foreach (var number in valuesTime)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }

        static double[] ReadNumbersFromConsole() 
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
        }
    }
}
