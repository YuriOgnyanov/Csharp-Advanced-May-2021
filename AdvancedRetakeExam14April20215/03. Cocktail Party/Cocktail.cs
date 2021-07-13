using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        public List<Ingredient> Data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }


        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            Data = new List<Ingredient>();
        }

        public void Add(Ingredient ingredient) 
        {
            Data.Add(ingredient);
        }

        public bool Remove(string name) 
        {
            Ingredient curr = Data.FirstOrDefault( x => x.Name == name);
            return Data.Remove(curr);
        }

        public string FindIngredient(string name) 
        {
            Ingredient curr = Data.FirstOrDefault(x => x.Name == name);
            return curr.ToString();
        }

    }
}
