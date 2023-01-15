using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // create list with Engines:
            List<Engine> allEngines = new List<Engine>();
            int engines = int.Parse(Console.ReadLine());

            for (int i = 0; i < engines; i++)
            {
                string[] engineData = Console.ReadLine().Split();
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine newEngine = new Engine(model, power);

                if (engineData.Length == 4)
                {
                    newEngine.Displacement = engineData[2];
                    newEngine.Efficiency = engineData[3];
                }
                else if (engineData.Length == 3)
                {
                    bool isDisplacement = int.TryParse(engineData[2], out int displacement);

                    if (isDisplacement)
                    {
                        newEngine.Displacement = engineData[2];
                    }
                    else
                    {
                        newEngine.Efficiency = engineData[2];
                    }
                }

                allEngines.Add(newEngine);
            }

            // create list with Cars:
            List<Car> allCars = new List<Car>();
            int cars = int.Parse(Console.ReadLine());

            for (int i = 0; i < cars; i++)
            {
                string[] carData = Console.ReadLine().Split();
                string model = carData[0];
                string engineModel = carData[1];

                Engine carEngine = allEngines.FirstOrDefault(engine => engine.Model == engineModel);
                Car newCar = new Car(model, carEngine);

                if (carData.Length == 4)
                {
                    newCar.Weight = carData[2];
                    newCar.Color = carData[3];
                }
                else if (carData.Length == 3)
                {
                    bool isWeight = int.TryParse(carData[2], out int weight);

                    if (isWeight)
                    {
                        newCar.Weight = carData[2];
                    }
                    else
                    {
                        newCar.Color = carData[2];
                    }
                }

                allCars.Add(newCar);
            }

            // print cars:
            foreach (Car car in allCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
