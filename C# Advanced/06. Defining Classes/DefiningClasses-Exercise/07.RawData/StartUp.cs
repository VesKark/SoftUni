using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                string model = inputCar[0];
                int engineSpeed = int.Parse(inputCar[1]);
                int enginePower = int.Parse(inputCar[2]);
                int cargoWeight = int.Parse(inputCar[3]);
                string type = inputCar[4];

                double tire1 = double.Parse(inputCar[5]);
                double tire2 = double.Parse(inputCar[7]);
                double tire3 = double.Parse(inputCar[9]);
                double tire4 = double.Parse(inputCar[11]);
                double[] tires = new double[] {tire1, tire2, tire3, tire4};

                if (type == "fragile" && !tires.Any(y => y < 1))
                {
                    continue;
                }

                Car currCar = new Car(model, engineSpeed, enginePower, cargoWeight, type, tires);
                allCars.Add(currCar);
            }

            string cargoType = Console.ReadLine();

            List<string> fragileCars = allCars
                .Where(x => x.Cargo.CargoType == "fragile")
                .Select(m => m.Model)
                .ToList();

            List<string> flammableCars = allCars
                .Where(x => x.Cargo.CargoType == "flammable")
                .Where(x => x.Engine.EnginePower > 250)
                .Select(m => m.Model)
                .ToList();

            if (cargoType == "fragile")
            {
                Console.WriteLine(String.Join("\n", fragileCars));
            }
            else if (cargoType == "flammable")
            {

                Console.WriteLine(String.Join("\n", flammableCars));
            }
        }
    }
}
