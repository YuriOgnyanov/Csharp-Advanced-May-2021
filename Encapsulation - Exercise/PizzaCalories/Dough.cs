using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flour;
        private string technique;
        private double weight;

        private const double CaloriesPerGramByDefaut = 2;
        private const int MinRangeForWeight = 1;
        private const int MaxRangeForWeight = 200;

        public Dough(string flour, string technique, double weight)
        {
            this.Flour = flour;
            this.Technique = technique;
            this.Weight = weight;
        }

        

        private readonly Dictionary<string, double> flourType = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> bakingTechnique = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        public string Flour
        {
            get { return this.flour; }
            private set 
            {
                if (!this.flourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flour = value.ToLower(); 
            }
        }

        public string Technique
        {
            get { return this.technique; }
            private set 
            {
                if (!this.bakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.technique = value.ToLower(); 
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set 
            {
                if (value < MinRangeForWeight || value > MaxRangeForWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinRangeForWeight}..{MaxRangeForWeight}].");
                }
                this.weight = value; 
            }
        }

        public double CalculateCalories => (CaloriesPerGramByDefaut * this.Weight) * this.flourType[this.Flour] * this.bakingTechnique[this.Technique];
                                    

    }
}
