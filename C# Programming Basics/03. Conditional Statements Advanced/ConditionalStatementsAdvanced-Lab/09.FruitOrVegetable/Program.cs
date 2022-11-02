using System;

namespace _09.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - food name:
            string food = Console.ReadLine();

            // Output - food type -> "fruit", "vegetable" or "unknown":
            switch (food)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable"); break;
                default:
                    Console.WriteLine("unknown"); break;
            }
        }
    }
}
