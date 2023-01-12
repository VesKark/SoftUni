using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
        private int Year { get; set; }
        private double Pressure { get; set; }
    }
}
