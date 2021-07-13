using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public List<int> Year { get; set; }
        public List<double> Pressure { get; set; }

        public Tire(List<int> year, List<double> pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
