using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            

            int nLines = int.Parse(Console.ReadLine());

            List<(string name, int age)> people = new List<(string name, int age)>();
            

            for (int i = 0; i < nLines; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add((person[0], int.Parse(person[1])));
                
            }

            string condition = Console.ReadLine();

            int filter = int.Parse(Console.ReadLine());

            string[] outputFormat = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (condition)
            {
                case "younger":
                    people = people
                        .Where(p => younger(p, filter))
                        .ToList();
                    break;

                case "older":
                    people = people
                        .Where(p => older(p, filter))
                        .ToList();
                    break;
            }

            foreach (var person in people)
            {
                if (outputFormat.Contains("name") && outputFormat.Contains("age"))
                {
                    Console.WriteLine($"{person.name} - {person.age}");
                }
                else if (outputFormat.Contains("name"))
                {
                    Console.WriteLine(person.name);
                }
                else if (outputFormat.Contains("age")) 
                {
                    Console.WriteLine(person.age);
                }
            }



        }
    }
}
