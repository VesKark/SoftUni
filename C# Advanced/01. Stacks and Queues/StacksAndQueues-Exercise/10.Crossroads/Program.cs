using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int durationGreen = int.Parse(Console.ReadLine()); //duration of the green light in seconds
        int freeWindow = int.Parse(Console.ReadLine()); //duration of the free window in seconds

        Queue<string> carsQueue = new Queue<string>();
        int carsSafelyPassed = 0;
        bool traficSafe = true;
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "END")
        {
            if (input == "green" && carsQueue.Count != 0)
            {
                int greenTimeOut = durationGreen;
                int passingCar = carsQueue.Peek().Length;

                while (greenTimeOut >= passingCar)
                {
                    carsQueue.Dequeue();
                    greenTimeOut -= passingCar;
                    carsSafelyPassed++;

                    if (carsQueue.Count == 0)
                    {
                        break;
                    }

                    passingCar = carsQueue.Peek().Length;
                }

                if (carsQueue.Count == 0)
                {
                    continue;
                }

                if (greenTimeOut == 0)
                {
                    continue;
                }

                int useWindow = greenTimeOut + freeWindow;

                if (useWindow >= passingCar)
                {
                    carsQueue.Dequeue();
                    carsSafelyPassed++;
                }
                else
                {
                    Console.WriteLine("A crash happened!");                    
                    Console.WriteLine($"{carsQueue.Peek()} was hit at {carsQueue.Peek()[useWindow]}.");
                    traficSafe = false;
                    break;
                }
            }
            else
            {
                carsQueue.Enqueue(input);
            }
        }

        if (traficSafe)
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsSafelyPassed} total cars passed the crossroads.");
        }
    }
}