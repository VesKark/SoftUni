using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine()); //days away from home [d]
            int food = int.Parse(Console.ReadLine()); //available food for the pets [kg]
            double foodDog = double.Parse(Console.ReadLine()); //needed food for the dog [kg/d]
            double foodCat = double.Parse(Console.ReadLine()); //needed food for the cat [kg/d]
            double foodTurtle = double.Parse(Console.ReadLine()); //needed food for the turtle [g/d]

            // Food to be consumed [kg]:
            double foodNeeded = days * (foodDog + foodCat + foodTurtle / 1000);

            // Check if food is enough:
            if (food >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
            }
        }
    }
}
