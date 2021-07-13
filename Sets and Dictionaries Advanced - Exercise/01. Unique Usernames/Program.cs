using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();

            //On the first line you will be given an integer N
            int nIterations = int.Parse(Console.ReadLine());

            //On the next N lines you will receive one username per line
            ReceiveUsernamePerLine(usernames, nIterations);

            //Print the collection on the console in order of insertion
            PrintTheCollections(usernames);
        }

        private static void PrintTheCollections(HashSet<string> usernames)
        {
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }

        private static void ReceiveUsernamePerLine(HashSet<string> usernames, int nIterations)
        {
            for (int i = 0; i < nIterations; i++)
            {
                string name = Console.ReadLine();

                usernames.Add(name);
            }
        }
    }
}
