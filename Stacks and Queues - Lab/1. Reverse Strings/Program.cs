using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads input Strings
            string input = Console.ReadLine(); // I Love C#
            //Reverse string it using Stack<T>
            Stack<char> charsStack = new Stack<char>(input.Length);
            foreach (char letter in input)
            {
                charsStack.Push(letter);
            }
            //Print the reversed string
            while (charsStack.Count != 0)
            {
                Console.Write(charsStack.Pop());
            }

        }
    }
}
