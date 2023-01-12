using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        private int HorsePower { get; set; }
        private double CubicCapacity { get; set; }
    }
}
