using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            // 1. collect tires:
            List<Tire[]> allCarTires = new List<Tire[]>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] carTires = input.Split();
                Tire[] fourTires = new Tire[4];
                int countTire = 0;

                for (int i = 0; i < 4; i++)
                {
                    int year = int.Parse(carTires[countTire]);
                    double pressure = double.Parse(carTires[countTire + 1]);
                    countTire += 2;
                    fourTires[i] = new Tire(year, pressure);
                }

                allCarTires.Add(fourTires);
            }

            // 2. collect engines:
            List<Engine> allEngines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                int horsePower = int.Parse(input.Split()[0]);
                double cubicCapacity = double.Parse(input.Split()[1]);

                allEngines.Add(new Engine(horsePower, cubicCapacity));
            }

            // 3. receive and save car information:
            List<Car> allCars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] newCar = input.Split();
                string make = newCar[0];
                string model = newCar[1];
                int year = int.Parse(newCar[2]);
                double fuelQuantity = double.Parse(newCar[3]);
                double fuelConsumption = double.Parse(newCar[4]);
                int engineIndex = int.Parse(newCar[5]);
                int tireIndex = int.Parse(newCar[6]);

                Car thisNewCar = new Car(make, model, year, fuelQuantity, fuelConsumption, allEngines[engineIndex], allCarTires[tireIndex]);

                allCars.Add(thisNewCar);
            }

            // 4. print all special cars:
            Func<Car, bool> filter = car => car.Year >= 2017 &&
                                            car.Engine.HorsePower > 330 &&
                                            car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                                            car.Tires.Select(x => x.Pressure).Sum() <= 10;
            
            foreach (Car car in allCars.Where(filter))
            {
                car.Drive(20);
                car.WhoAmI();                
            }
        }
    }
}
