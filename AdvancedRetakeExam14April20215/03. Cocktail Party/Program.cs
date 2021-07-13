using System;

namespace CocktailParty
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Sample Code Usage:

            //Initialize Cocktail
            Cocktail cocktail = new Cocktail("Pina Colada", 3, 10);

            //Initialize Ingredient
            Ingredient rum = new Ingredient("Rum", 2, 3);

            //Print rum
            Console.WriteLine(rum.ToString());

            //Ingredient: Rum
            //Quantity: 3
            //Alcohol: 2

        }
    }
}
