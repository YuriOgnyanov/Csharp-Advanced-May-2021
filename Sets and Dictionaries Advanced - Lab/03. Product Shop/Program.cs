using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints information about food shops in Sofia and the products they store. 
            //Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".
            //Keep in mind that if you receive a shop you already have  received, you must collect its product information.

            SortedDictionary<string, Dictionary<string, double>> productShop = new SortedDictionary<string, Dictionary<string, double>>();

            //Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".
            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] cmdArgs = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = cmdArgs[0];
                string product = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if (productShop.ContainsKey(shop))
                {
                    productShop[shop].Add(product, price);
                }
                else
                {
                    productShop.Add(shop, new Dictionary<string, double>());
                    productShop[shop].Add(product, price);
                }
                    

                input = Console.ReadLine();
            }

            foreach (var shop in productShop)
            {
                Console.WriteLine($"{shop.Key}->");
                
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
