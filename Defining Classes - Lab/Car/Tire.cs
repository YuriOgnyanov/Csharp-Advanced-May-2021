

namespace CarManufacturer
{
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        //The class should also have a constructor, which accepts year and pressure upon initialization:
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
