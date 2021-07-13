using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : ICitizenInterface, IBuyer
    {
        public int Food { get; private set; } = 0;

        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Group { get; private set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
