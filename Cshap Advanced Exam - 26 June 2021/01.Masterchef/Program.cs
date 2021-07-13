using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int drippingSauce = 150;
            int greenSalad = 250;
            int chocolateCake = 300;
            int lobster = 400;


            //First you will receive a sequence of integers, representing the number of ingredients in a single basket.
            int[] sequenceOfInteger = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //After that you will be given another sequence of integers - the freshness level of the ingredients.
            int[] freshnessSequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Queue - съставки
            Queue<int> ingredients = new Queue<int>(sequenceOfInteger);

            //Stack - Свежест
            Stack<int> freshness = new Stack<int>(freshnessSequence);

            SortedDictionary<string, int> result = new SortedDictionary<string, int>();
            result.Add("Dipping sauce", 0);
            result.Add("Green salad", 0);
            result.Add("Chocolate cake", 0);
            result.Add("Lobster", 0);

            while (ingredients.Any() && freshness.Any())
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int multiplication = ingredients.Peek() * freshness.Peek();

                if (multiplication == drippingSauce)
                {
                    result["Dipping sauce"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == greenSalad)
                {
                    result["Green salad"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == chocolateCake)
                {
                    result["Chocolate cake"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == lobster)
                {
                    result["Lobster"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }


            if (result["Dipping sauce"] >= 1 && result["Green salad"] >= 1 && result["Chocolate cake"] >= 1 && result["Lobster"] >= 1)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");

            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }
            

            foreach (var item in result.Where(x => x.Value >= 1))
            {
                Console.WriteLine($"# {item.Key} --> {item.Value}");
            }




        }
    }
}
