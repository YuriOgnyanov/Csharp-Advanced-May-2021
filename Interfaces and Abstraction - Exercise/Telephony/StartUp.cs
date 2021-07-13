using System;
using Telephony.Models;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //•	First line: phone numbers to call (string), separated by spaces

            string[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //•	Second line: sites to visit (string), separated by spaces.

            string[] urlSites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length == 10)
                {
                    try
                    {
                        Smartphone smartphone = new Smartphone();
                        smartphone.PhoneNumbers = phoneNumber;
                        Console.WriteLine(smartphone.Call());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else
                {
                    try
                    {
                        StationaryPhone stationaryPhone = new StationaryPhone();
                        stationaryPhone.PhoneNumbers = phoneNumber;
                        Console.WriteLine(stationaryPhone.Call());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }

            foreach (var url in urlSites)
            {
                try
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.UrlSurf = url;
                    Console.WriteLine(smartphone.Surf());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            
        }
    }
}
