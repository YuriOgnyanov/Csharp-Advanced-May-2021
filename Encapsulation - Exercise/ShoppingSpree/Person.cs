using System;
using System.Collections.Generic;
using System.Text;


namespace ShoppingSpree
{
    public class Person
    {
        //Each person should have a name, money and a bag of products
        private string name;
        private decimal money;

        public ICollection<Product> data;



        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value > -1)
                {
                    this.money = value;
                }
            }
        }

        public void AddProduct(Product product)
        {

            if (product.Price <= this.Money)
            {
                data.Add(product);

                this.Money -= product.Price;

            }
            else
            {
                throw new ArgumentException("Money cannot be negative");
            }

        }
    }
}
