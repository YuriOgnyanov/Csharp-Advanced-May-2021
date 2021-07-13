﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }
    }
}
