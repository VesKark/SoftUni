using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List <Car> allCars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                string model = inputCar[0];
                int engineSpeed = int.Parse(inputCar[1]);
                int enginePower = int.Parse(inputCar[2]);
                int cargoWeight = int.Parse(inputCar[3]);
                string type = inputCar[4];

                Car currCar = new Car(model, engineSpeed, enginePower, cargoWeight, type);
                allCars.Add(currCar);
            }

            string cargoType = Console.ReadLine();

            List<string> fragileCars = allCars
                .Where(x => x.Cargo.CargoType == "fragile")
                .Where(x => x.Cargo.CargoWeight < 1000)
                .Select(m => m.Model)
                .ToList();

            List<string> flamableCars = allCars
                .Where(x => x.Cargo.CargoType == "flamable")
                .Where(x => x.Engine.EnginePower > 250)
                .Select(m => m.Model)
                .ToList();

            if (cargoType == "fragile")
            {
                Console.WriteLine(String.Join("\n", fragileCars));
            }
            else if (cargoType == "flamable")
            {
                Console.WriteLine(String.Join("\n", flamableCars));
            }
        }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }
    
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            CargoWeight = weight;
            CargoType = type;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
