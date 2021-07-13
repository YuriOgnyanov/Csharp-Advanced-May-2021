using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            string input = Console.ReadLine();
            int counter = 0;
            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                    counter = 0;
                }
                else
                {
                    people.Enqueue(input);
                    counter++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
