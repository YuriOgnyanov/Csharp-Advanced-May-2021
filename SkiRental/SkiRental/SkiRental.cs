using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count;

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            data = new List<Ski>();
        }

        public void Add(Ski ski) 
        {
            if (Capacity > Count)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model) 
        {
            Ski ski = data.Where(x => x.Manufacturer == manufacturer).FirstOrDefault(x => x.Model == model);
            return data.Remove(ski);
        }

        public Ski GetNewestSki() 
        {
            Ski ski = data.OrderByDescending(x => x.Year).FirstOrDefault();
            return ski;
        }

        public Ski GetSki(string manufacturer, string model) 
        {
            Ski ski = data.Where(x => x.Manufacturer == manufacturer).FirstOrDefault(x => x.Model == model);
            return ski;
        }

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {this.Name}:");

            foreach (var item in data)
            {
                sb.AppendLine($"{item.Manufacturer} - {item.Model} - {item.Year}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
