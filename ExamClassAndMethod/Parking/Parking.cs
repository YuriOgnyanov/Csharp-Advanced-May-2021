
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public string Type { get; set; }
        public int Capacity { get; set; }

        //The class constructor should receive type and capacity
        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            //also it should initialize the data with a new instance of the collection.
            data = new List<Car>();
        }

        public void Add(Car car) 
        {
            if (Capacity > 0)
            {
                data.Add(car);
                Capacity--;
            }
            
        }

        public bool Remove(string manufacturer, string model) 
        {
            Car car = data.FirstOrDefault(x => x.Manufacturer == manufacturer);
            car = data.FirstOrDefault(x => x.Model == model);

            return data.Remove(car);
        }

        public Car GetLatestCar() 
        {
            Car latestCar = data.OrderByDescending(x => x.Year).FirstOrDefault();
            return latestCar;
        }

        public Car GetCar(string manufacturer, string model) 
        {
            Car car = data.FirstOrDefault(x => x.Manufacturer == manufacturer);
            car = data.FirstOrDefault(x => x.Model == model);

            return car;
        }

        public int Count => data.Count();

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
