using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            CheckAndAddElements(result, text);

            PrintResult(result);
        }

        private static void PrintResult(SortedDictionary<char, int> result)
        {
            foreach (var letter in result)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }

        private static void CheckAndAddElements(SortedDictionary<char, int> result, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (result.ContainsKey(text[i]))
                {
                    result[text[i]]++;
                }
                else
                {
                    result.Add(text[i], 1);
                }
            }
        }
    }
}
