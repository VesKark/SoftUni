using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
        public Car(string model, int speed, int power, int weight, string type, double[] tires)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tires = new double[4];
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public double[] Tires { get; set; }
    }
}
