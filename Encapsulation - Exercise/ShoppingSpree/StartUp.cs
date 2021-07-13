using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();


            List<string> namesAndMoney = Console.ReadLine().Split(";").ToList();
            try
            {

                for (int i = 0; i < namesAndMoney.Count; i++)
                {
                    var splited = namesAndMoney[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = splited[0];
                    decimal money = decimal.Parse(splited[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }



            List<string> foodAndPrice = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < foodAndPrice.Count; i++)
            {
                var splited = foodAndPrice[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = splited[0];
                decimal cost = decimal.Parse(splited[1]);
                Product product = new Product(name, cost);
                products.Add(product);

            }



            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] convert = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = convert[0];
                string productName = convert[1];

                try
                {
                    Product product = products.Where(a => a.Name == productName).FirstOrDefault();
                    foreach (var person in people)
                    {
                        if (person.Name == personName)
                        {
                            person.AddProduct(product);
                            Console.WriteLine($"{person.Name} bought {product.Name}");
                        }

                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }
                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.data.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                    Console.WriteLine(string.Join(", ", person.data));
            }
        }
    }
}
