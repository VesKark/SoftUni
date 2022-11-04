using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countPeople = int.Parse(Console.ReadLine()); //count of people in the group
            string groupType = Console.ReadLine(); //"Students", "Business" or "Regular"
            string dayOfWeek = Console.ReadLine(); //"Friday", "Saturday" or "Sunday"

            // Assigning price per day:
            double pricePerDay = 0;

            if (dayOfWeek == "Friday")
            {
                switch (groupType)
                {
                    case "Students": pricePerDay = 8.45; break;
                    case "Business": pricePerDay = 10.90; break;
                    case "Regular": pricePerDay = 15.00; break;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (groupType)
                {
                    case "Students": pricePerDay = 9.80; break;
                    case "Business": pricePerDay = 15.60; break;
                    case "Regular": pricePerDay = 20.00; break;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (groupType)
                {
                    case "Students": pricePerDay = 10.46; break;
                    case "Business": pricePerDay = 16.00; break;
                    case "Regular": pricePerDay = 22.50; break;
                }
            }

            // Estimating total vacation costs:
            double totalCosts = countPeople * pricePerDay;

            switch (groupType)
            {
                case "Students":
                    if (countPeople >= 30)
                    {
                        totalCosts *= 0.85; //discount 15%
                    }
                    break;
                case "Business":
                    if (countPeople >= 100)
                    {
                        totalCosts -= 10 * pricePerDay; //10 people stay for free
                    }
                    break;
                case "Regular":
                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        totalCosts *= 0.95; //discount 5%
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalCosts:F2}");
        }
    }
}
