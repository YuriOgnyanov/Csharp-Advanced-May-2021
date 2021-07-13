using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        //private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        private string firstName;

        public string FirstName
        {
            get { return this.firstName; }

            private set 
            {
                if (value.Length > 2)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }


        //public string FirstName
        //{
        //    get { return this.firstName; }

        //    private set
        //    {
        //        if (value.Length > 2)
        //        {
        //            this.firstName = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        //        }
        //    }
        //}
        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (value.Length > 2)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get { return this.age; }

            private set
            {
                if (age > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get { return this.salary; }

            private set 
            {
                if (this.salary > 459)
                {
                    this.salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }


        }
    }
}
