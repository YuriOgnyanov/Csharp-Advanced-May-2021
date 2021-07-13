using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            //First, you will be receiving the reservation numbers of the guests.
            string input = Console.ReadLine();


            while (input != "END")
            {
                //"PARTY" – After this command you will begin receiving the reservation numbers of the people, who actually came to the party.
                if (input == "PARTY")
                {
                    input = Console.ReadLine();
                    while (input != "END")
                    {
                        if (vipGuests.Contains(input))
                        {
                            vipGuests.Remove(input);
                        }

                        if (regularGuests.Contains(input))
                        {
                            regularGuests.Remove(input);
                        }

                        input = Console.ReadLine();
                    }
                    continue;
                }

                //All VIP numbers start with a digit.
                int num;

                if (int.TryParse(input[0].ToString(), out num))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }


                input = Console.ReadLine();
            }

            //In the end, print the count of the quests who didn't come to the party and afterwards, print their reservation numbers. the VIP guests must be first.

            PrintTheResult(regularGuests, vipGuests);
        }

        private static void PrintTheResult(HashSet<string> regularGuests, HashSet<string> vipGuests)
        {
            Console.WriteLine(regularGuests.Count + vipGuests.Count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
