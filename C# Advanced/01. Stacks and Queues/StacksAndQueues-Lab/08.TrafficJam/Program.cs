using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> trafficCars = new Queue<string>();
        int carsCounter = int.Parse(Console.ReadLine());
        int carsPassed = 0;
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "end")
        {
            if (input == "green")
            {
                for (int i = 0; i < carsCounter; i++)
                {
                    if (trafficCars.Count == 0)
                    {
                        continue;
                    }

                    string passingCar = trafficCars.Dequeue();
                    Console.WriteLine($"{passingCar} passed!");
                    carsPassed++;
                }
            }
            else
            {
                trafficCars.Enqueue(input);
            }
        }

        Console.WriteLine($"{carsPassed} cars passed the crossroads.");
    }
}
