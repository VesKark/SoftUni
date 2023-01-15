using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public Car(double fuelAmount, double fuelConsumption)
        {
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void MoveCar(double distance)
        {
            double maxDistance = FuelAmount / FuelConsumption;

            if (distance > maxDistance)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distance * FuelConsumption;
                TraveledDistance += distance;
            }
        }
    }
}
