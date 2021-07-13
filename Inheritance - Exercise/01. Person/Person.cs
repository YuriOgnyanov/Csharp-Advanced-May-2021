using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        
        public virtual int Age 
        {
            get 
            {
                return this.age;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                this.age = value;
            }
            
        }

        public string Name { get; set; }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
