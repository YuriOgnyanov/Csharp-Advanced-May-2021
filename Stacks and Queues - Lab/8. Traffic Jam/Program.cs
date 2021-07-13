using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            //On the first line you will receive N – the number of cars that can pass during a green light
            int nCars = int.Parse(Console.ReadLine());

            //On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green"
            string input = Console.ReadLine();

            int counter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < nCars; i++)
                    {
                        if (cars.Any())
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
        
    }
}
