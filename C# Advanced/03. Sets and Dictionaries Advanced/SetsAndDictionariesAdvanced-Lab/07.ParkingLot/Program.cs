using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> parking = new HashSet<string>();
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] carData = input.Split(", ");
            string carPlate = carData[1];

            if (carData[0] == "IN")
            {
                parking.Add(carPlate);
            }
            else if (carData[0] == "OUT")
            {
                parking.Remove(carPlate);
            }
        }

        if (parking.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }

        foreach (string carPlate in parking)
        {
            Console.WriteLine(carPlate);
        }
    }
}