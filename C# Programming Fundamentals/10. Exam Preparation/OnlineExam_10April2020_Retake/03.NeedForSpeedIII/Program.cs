using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // input all cars:
        Dictionary<string, CarParameters> allCars = new Dictionary<string, CarParameters>();
        int numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            string[] inputCar = Console.ReadLine().Split('|');
            string carName = inputCar[0];
            int mileage = int.Parse(inputCar[1]);
            int fuel = int.Parse(inputCar[2]);

            CarParameters currCar = new CarParameters(mileage, fuel);
            allCars[carName] = currCar;
        }

        // operate cars:
        string command = string.Empty;
        string[] separator = new string[] { " : " };

        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] currCommand = command.Split(separator, StringSplitOptions.None);
            string action = currCommand[0];
            string car = currCommand[1];
            int carValue = int.Parse(currCommand[2]);

            if (action == "Drive")
            {
                int neededFuel = int.Parse(currCommand[3]);

                if (allCars[car].Fuel < neededFuel)
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }
                else
                {
                    allCars[car].Mileage += carValue; //increase distance
                    allCars[car].Fuel -= neededFuel; //decrease fuel
                    Console.WriteLine("{0} driven for {1} kilometers. {2} liters of fuel consumed.", car, carValue, neededFuel);

                    if (allCars[car].Mileage >= 100000)
                    {
                        Console.WriteLine("Time to sell the {0}!", car);
                        allCars.Remove(car);
                    }
                }
            }
            else if (action == "Refuel")
            {
                allCars[car].Fuel += carValue; //increase fuel
                int fuleOverTop = 0;

                if (allCars[car].Fuel > 75)
                {
                    fuleOverTop = allCars[car].Fuel - 75;
                    allCars[car].Fuel = 75;
                }

                Console.WriteLine("{0} refueled with {1} liters", car, carValue - fuleOverTop);
            }
            else if (action == "Revert")
            {
                allCars[car].Mileage -= carValue; //decrease distance
                if (allCars[car].Mileage < 10000)
                {
                    allCars[car].Mileage = 10000;
                }
                else
                {
                    Console.WriteLine("{0} mileage decreased by {1} kilometers", car, carValue);
                }
            }
        }

        // print all cars:
        foreach (var car in allCars)
        {
            Console.WriteLine("{0} -> Mileage: {1} kms, Fuel in the tank: {2} lt.", car.Key, car.Value.Mileage, car.Value.Fuel);
        }
    }
}

class CarParameters
{
    public CarParameters(int mileage, int fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }

    public int Mileage { get; set; }
    public int Fuel { get; set; }
}