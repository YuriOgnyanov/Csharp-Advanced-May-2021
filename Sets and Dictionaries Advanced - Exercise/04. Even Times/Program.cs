using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenNumber = new Dictionary<int, int>();

            //On the first line, you will be given n – the count of integers you will receive
            int nIterationForRead = int.Parse(Console.ReadLine());

            //On the next n lines you will be receiving the numbers
            ReadCurrentNumbersAndAddToDictionary(evenNumber, nIterationForRead);

            //Your task is to find that number and print it in the end. 
            FindAndPrintNumber(evenNumber);

        }

        private static void FindAndPrintNumber(Dictionary<int, int> evenNumber)
        {
            foreach (var item in evenNumber)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        private static void ReadCurrentNumbersAndAddToDictionary(Dictionary<int, int> evenNumber, int nIterationForRead)
        {
            for (int i = 0; i < nIterationForRead; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (evenNumber.ContainsKey(currNumber))
                {
                    evenNumber[currNumber]++;
                }
                else
                {
                    evenNumber.Add(currNumber, 1);
                }
            }
        }
    }
}
