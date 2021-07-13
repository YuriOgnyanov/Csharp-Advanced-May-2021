using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numbersOfPeople = int.Parse(Console.ReadLine());


            Family family = new Family();

            for (int i = 0; i < numbersOfPeople; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = person[0];
                int age = int.Parse(person[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
                
            }

            Console.WriteLine(family.GetOldestMember());

           

            
        }
    }
}
