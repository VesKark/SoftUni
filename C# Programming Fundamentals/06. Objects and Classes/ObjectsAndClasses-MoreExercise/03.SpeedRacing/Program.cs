using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                string model = inputCar[0];
                double fuelAmount = double.Parse(inputCar[1]);
                double fuelConsumption = double.Parse(inputCar[2]);

                Car currCar = new Car(fuelAmount, fuelConsumption);
                allCars.Add(model, currCar);
            }

            string input = string.Empty;

            while((input = Console.ReadLine()) != "End")
            {
                string[] driveCar = input.Split();
                string model = driveCar[1];
                double kmAmount = double.Parse(driveCar[2]);

                allCars[model].MoveCar(kmAmount);
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.TraveledDistance}");
            }
        }
    }

    class Car
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
