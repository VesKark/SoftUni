using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> Cars { get; set; }
        public int Count { get; private set; }

        private int capacity;
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            this.capacity = capacity;
            Count = 0;
        }

        public string AddCar(Car car)
        {
            if (Cars.Any(x => x.RegNr == car.RegNr))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count >= this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                Count = Cars.Count;
                return $"Successfully added new car {car.Make} {car.RegNr}";
            }
        }

        public string RemoveCar(string regNr)
        {
            if (Cars.Any(x => x.RegNr == regNr))
            {
                Car thisCar = Cars.Find(x => x.RegNr == regNr);
                Cars.Remove(thisCar);
                Count = Cars.Count;
                return $"Successfully removed {regNr}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string regNr)
        {
            return Cars.Find(x => x.RegNr == regNr);            
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {
                string currRegNr = registrationNumbers[i];
                RemoveCar(currRegNr);
            }

            Count = Cars.Count;
        }
    }
}
