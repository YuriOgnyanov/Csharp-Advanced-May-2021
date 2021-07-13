using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Model
{
    public class Citizen : ICitizens, IBuyer
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }

        public int Food { get; private set; } = 0;

        public Citizen(string name, int age, string Id, string birthdata)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
            this.Birthdate = birthdata;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }

    }
}
