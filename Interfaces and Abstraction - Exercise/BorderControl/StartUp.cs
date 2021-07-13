using BorderControl.Contracts;
using BorderControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Citizen> citizenCollection = new HashSet<Citizen>();
            HashSet<Rebel> RebelCollection = new HashSet<Rebel>();

            HashSet<IBuyer> buyer = new HashSet<IBuyer>();

            
            //On the first line of the input you will receive an integer N - the number of people
            int line = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < line; i++)
            {
                //on each of the next N lines you will receive information in one of the following formats "<name> <age> <id> <birthdate>" for a Citizen or "<name> <age><group>" for a Rebel
                string[] information = Console.ReadLine()
                    .Split();

                if (information.Length == 4)
                {
                    Citizen citizen = new Citizen(information[0], int.Parse(information[1]), information[2], information[3]);
                    citizenCollection.Add(citizen);
                }
                else if (information.Length == 3)
                {
                    Rebel rebel = new Rebel(information[0], int.Parse(information[1]), information[2]);
                    RebelCollection.Add(rebel);
                }
            }
            ;
            //After the N lines until the command "End" is received, you will receive names of people who bought food, each on a new line
            string input = Console.ReadLine();

            while (input != "End")
            {





                input = Console.ReadLine();
            }

            
        }
    }
}
