using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double otherFoodPrice = 4.00;

            double priceForAll = (numberOfDogs * dogFoodPrice) + (numberOfOtherAnimals * otherFoodPrice);
            Console.WriteLine(priceForAll + " lv.");
        }
    }
}
