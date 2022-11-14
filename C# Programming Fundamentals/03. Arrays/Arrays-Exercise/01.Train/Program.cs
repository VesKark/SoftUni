using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int wagons = int.Parse(Console.ReadLine());

            // Assigning wagon passengers:
            int[] train = new int[wagons];
            int passengerSum = 0;

            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                passengerSum += train[i];
            }

            // Printing train:
            foreach (int wagon in train)
            {
                Console.Write(wagon + " ");
            }
            Console.WriteLine("\n" + passengerSum);
        }
    }
}
