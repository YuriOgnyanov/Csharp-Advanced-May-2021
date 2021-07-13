using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class Startup
    {
        static void Main(string[] args)
        {
            HashSet<IBuyer> all = new HashSet<IBuyer>();

            //On the first line of the input you will receive an integer N - the number of people
            int line = int.Parse(Console.ReadLine());

            Citizen citizen;
            Rebel rebel;
            for (int i = 0; i < line; i++)
            {
                //on each of the next N lines you will receive information in one of the following formats "<name> <age> <id> <birthdate>" for a Citizen or "<name> <age><group>" for a Rebel
                string[] information = Console.ReadLine()
                    .Split();

                if (information.Length == 4)
                {
                    citizen = new Citizen(information[0], int.Parse(information[1]), information[2], information[3]);
                    all.Add(citizen);
                }
                else if (information.Length == 3)
                {
                    rebel = new Rebel(information[0], int.Parse(information[1]), information[2]);
                    all.Add(rebel);
                }
            }
            ;
            //After the N lines until the command "End" is received, you will receive names of people who bought food, each on a new line
            string input = Console.ReadLine();

            while (input != "End")
            {
                var bayer = all.SingleOrDefault(x => x.Name == input);

                if (bayer != null)
                {
                    bayer.BuyFood();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(all.Sum(x => x.Food)) ;
        }
    }
}
