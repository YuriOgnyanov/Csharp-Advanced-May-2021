using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private Dough dough;
        private string name;
        private readonly List<Topping> toppings;

        private const int MaxNumberOfToppings = 10;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value; 
            }
        }

        public int CountOfToppings => this.toppings.Count;

        public double TotalCalories => CalculateTotalCalories();

        public void AddTopping(Topping topping) 
        {
            if (CountOfToppings == MaxNumberOfToppings)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxNumberOfToppings}].");
            }

            toppings.Add(topping);
        }

        public Dough Dough
        {
            get { return this.dough; }
            private set { this.dough = value; }
        }

        private double CalculateTotalCalories()
        {
            double result = 0;
            foreach (var topping in toppings)
            {
                result += topping.CalculateCaloriesPerGram;
            }

            return result;
        }







    }
}
