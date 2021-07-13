using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmdArgs = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string numberOfCar = cmdArgs[1];

                if (command == "IN")
                {
                    parking.Add(numberOfCar);
                }
                else if (command == "OUT")
                {
                    parking.Remove(numberOfCar);
                }


                input = Console.ReadLine();
            }

            if (!parking.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var numberOfCar in parking)
            {
                Console.WriteLine(numberOfCar);
            }
        }
    }
}
