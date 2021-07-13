using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            //First, you will be given the quantity of the food that you have for the day (an integer number).
            int quantityFood = int.Parse(Console.ReadLine());

            //Next, you will be given a sequence of integers, each representing the quantity of an order.
            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Keep the orders in a queue
            Queue<int> ordersQueue = new Queue<int>(orders);

            //Find the biggest order and print it
            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Any())
            {
                //You will begin servicing your clients from the first one that came. Before each order, check if you have enough food left to complete it.
                if (quantityFood - ordersQueue.Peek() >= 0)
                {
                    //If you have, remove the order from the queue and reduce the amount of food you have.
                    quantityFood -= ordersQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    return;
                }
            }

            //If you succeeded in servicing all of your clients, print .......
            Console.WriteLine("Orders complete");

        }
    }
}
