using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string sauce;
        private double weight;

        private const double CaloriesPerGramByDefaut = 2;
        private const int MinRangeForWeight = 1;
        private const int MaxRangeForWeight = 50;

        public Topping(string sauce, double weight)
        {
            this.Sauce = sauce;
            this.Weight = weight;
        }

        private readonly Dictionary<string, double> souceType = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        public string Sauce
        {
            get { return this.sauce; }
            private set 
            {
                if (!this.souceType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.sauce = value.ToLower(); 
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set 
            {
                if (value < MinRangeForWeight || value > MaxRangeForWeight)
                {
                    throw new ArgumentException($"{this.Sauce} weight should be in the range [{MinRangeForWeight}..{MaxRangeForWeight}].");
                }
                
                this.weight = value; 
            }
        }

        public double CalculateCaloriesPerGram => (CaloriesPerGramByDefaut * this.souceType[this.Sauce]) * this.Weight;
    }
}
