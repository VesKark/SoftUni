using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegNr { get; set; }

        public Car(string make, string model, int hp, string regNr)
        {
            Make = make;
            Model = model;
            HorsePower = hp;
            RegNr = regNr;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.Append($"RegistrationNumber: {RegNr}");

            return sb.ToString();
        }
    }
}
