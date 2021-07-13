using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> evulateNumbers = new Stack<string>(input.Length - 1);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                evulateNumbers.Push(input[i]);
            }

            while (evulateNumbers.Count > 1)
            {
                int firstNum = int.Parse(evulateNumbers.Pop());
                string opr = evulateNumbers.Pop();
                int secondNum = int.Parse(evulateNumbers.Pop());

                if (opr == "+")
                {
                    evulateNumbers.Push((firstNum + secondNum).ToString());
                }
                else
                {
                    evulateNumbers.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(evulateNumbers.Peek());
        }
    }
}
