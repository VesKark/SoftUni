using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();
			List<Cars> carsCatalog = new List<Cars>();
			List<Trucks> trucksCatalog = new List<Trucks>();

			while (input != "end")
			{
				string[] thisVehicle = input.Split('/');

				if (thisVehicle[0] == "Car")
				{
					Cars car = new Cars();
					car.Brand = thisVehicle[1];
					car.Model = thisVehicle[2];
					car.HorsePower = int.Parse(thisVehicle[3]);
					carsCatalog.Add(car);
				}
				else if (thisVehicle[0] == "Truck")
				{
					Trucks truck = new Trucks();
					truck.Brand = thisVehicle[1];
					truck.Model = thisVehicle[2];
					truck.Weight = int.Parse(thisVehicle[3]);
					trucksCatalog.Add(truck);
				}

				input = Console.ReadLine();
			}

			List<Cars> carsCatalogSorted = carsCatalog.OrderBy(x => x.Brand).ToList();
			List<Trucks> trucksCatalogSorted = trucksCatalog.OrderBy(x => x.Brand).ToList();

			Console.WriteLine("Cars:");
			foreach (Cars vehicle in carsCatalogSorted)
			{
				Console.WriteLine("{0}: {1} - {2}hp", vehicle.Brand, vehicle.Model, vehicle.HorsePower);
			}

			Console.WriteLine("Trucks:");
			foreach (Trucks vehicle in trucksCatalogSorted)
			{
				Console.WriteLine("{0}: {1} - {2}kg", vehicle.Brand, vehicle.Model, vehicle.Weight);
			}
		}
    }

    class VehicleCatalog
    {
        public string Trucks { get; set; }
        public string Cars { get; set; }
    }

    class Trucks
    {
        public VehicleCatalog Vehicle { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Cars
    {
        public VehicleCatalog Vehicle { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }


}
