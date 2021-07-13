using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                //final MainMethod

                //Pizza cmdArgs;
                string[] pizzaArgs = Console.ReadLine()
                    .Split();

                string nameOnPizza = pizzaArgs[1];

                Pizza pizza = new Pizza(nameOnPizza);

                //Dough cmdArgs;
                string[] doughArgs = Console.ReadLine()
                    .Split();

                string typeOfDough = doughArgs[1];
                string technique = doughArgs[2];
                double grams = double.Parse(doughArgs[3]);

                Dough dough = new Dough(typeOfDough, technique, grams);

                //while 
                string input = Console.ReadLine();

                while (input != "END")
                {
                    //Topping cmdArgs;
                    string[] toppingArgs = input
                        .Split();
                    string classType = toppingArgs[0];
                    string typeOfTopping = toppingArgs[1];
                    double toppingGrams = double.Parse(toppingArgs[2]);
                    
                    Topping topping = new Topping(typeOfTopping, toppingGrams);

                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories + dough.CalculateCalories:F2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
