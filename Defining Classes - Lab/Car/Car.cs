

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }

        //constructor with default values
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        //Create a second constructor accepting make, model and year upon initialization and calls the base constructor with its default values for fuelQuantity and fuelConsumption.
        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        //Create a third constructor accepting make, model, year, fuelQuantity and fuelConsumption upon initialization and reuses the second constructor to set the make, model and year values.
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }

        //Create another constructor, which accepts make, model, year, fuelQuantity, fuelConsumption, Engine and Tire[] upon initialization:
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tire)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tire = tire;
        }

        public void Drive(double distance)
        {
            //checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero
            double leftFuel = FuelQuantity - distance * FuelQuantity;

            if (leftFuel >= 0)
            {
                //. If it is remove from the fuel quantity the result of the multiplication between the distance and the fuel consumption
                FuelQuantity -= leftFuel;
            }
            else
            {
                //Otherwise write on the console the following message:
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: { this.Make} Model: { this.Model} Year: { this.Year} Fuel: { this.FuelQuantity:F2}";
        }

    }
}
