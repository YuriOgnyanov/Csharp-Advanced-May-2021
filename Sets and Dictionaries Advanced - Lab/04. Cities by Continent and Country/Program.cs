using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            //N iterations For Continents
            int nIterationsOfContinents = int.Parse(Console.ReadLine());

            //Use a nested dictionary (string  (Dictionary  List<string>))
            Dictionary<string, Dictionary<string, List<string>>> ContinentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < nIterationsOfContinents; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continents = cmdArgs[0];
                string contries = cmdArgs[1];
                string cities = cmdArgs[2];

                //Check if the continent exists before adding the country. If it doesn’t, add it to the dictionary.
                if (ContinentsCountriesCities.ContainsKey(continents))
                {
                    if (ContinentsCountriesCities[continents].ContainsKey(contries))
                    {
                        ContinentsCountriesCities[continents][contries].Add(cities);
                    }
                    else
                    {
                        ContinentsCountriesCities[continents].Add(contries, new List<string>() { cities });
                    }
                    
                }
                else
                {
                    ContinentsCountriesCities.Add(continents, new Dictionary<string, List<string>>());
                    ContinentsCountriesCities[continents].Add(contries, new List<string>() { cities });
                }
            }

            //Print the results
            foreach (var continets in ContinentsCountriesCities)
            {
                Console.WriteLine($"{continets.Key}:");
                foreach (var contries in continets.Value)
                {
                    Console.WriteLine($" {contries.Key} -> {string.Join(", ", contries.Value)}");
                }
            }

            

        }
    }
}
