using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputVehicle;
            List<Catalogue> allVehicles = new List<Catalogue>();

            while ((inputVehicle = Console.ReadLine()) != "End")
            {
                string[] inputCurrVehicle = inputVehicle.Split();
                string type = inputCurrVehicle[0];
                type = char.ToUpper(type[0]) + type.Substring(1); //uppercase first letter
                string model = inputCurrVehicle[1]; 
                string color = inputCurrVehicle[2];
                int horsepower = int.Parse(inputCurrVehicle[3]);

                Catalogue currVehicle = new Catalogue(type, model, color, horsepower);
                allVehicles.Add(currVehicle);
            }

            while ((inputVehicle = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Catalogue vehicle in allVehicles.Where(x => x.Model == inputVehicle))
                {
                    Console.WriteLine(vehicle);
                }                
            }

            double averageHPcars = 0;
            if (allVehicles.Where(x => x.Type == "Car").Count() != 0)
            {
                averageHPcars = allVehicles.Where(x => x.Type == "Car").Select(x => x.Horsepower).Average();
            }

            double averageHPtrucks = 0;
            if (allVehicles.Where(x => x.Type == "Truck").Count() != 0)
            {
                averageHPtrucks = allVehicles.Where(x => x.Type == "Truck").Select(x => x.Horsepower).Average();
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHPcars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHPtrucks:F2}.");
        }
    }

    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}
