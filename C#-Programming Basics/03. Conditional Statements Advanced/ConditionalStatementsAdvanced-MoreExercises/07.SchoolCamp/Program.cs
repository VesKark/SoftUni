using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string season = Console.ReadLine(); //"Winter", "Spring" or "Summer"
            string group = Console.ReadLine(); //"boys", "girls" or "mixed"
            int students = int.Parse(Console.ReadLine()); //number of students
            int nights = int.Parse(Console.ReadLine()); //number of nights

            // Estimating camp costs:
            double totalPrice = 0;

            switch (season)
            {
                case "Winter":
                    if (group == "mixed")
                    {
                        totalPrice = students * nights * 10.00;
                    }
                    else
                    {
                        totalPrice = students * nights * 9.60;
                    }
                    break;
                case "Spring":
                    if (group == "mixed")
                    {
                        totalPrice = students * nights * 9.50;
                    }
                    else
                    {
                        totalPrice = students * nights * 7.20;
                    }
                    break;
                case "Summer":
                    if (group == "mixed")
                    {
                        totalPrice = students * nights * 20.00;
                    }
                    else
                    {
                        totalPrice = students * nights * 15.00;
                    }
                    break;
            }

            // Estimating camp costs after discount:
            if (students >= 10 && students < 20)
            {
                totalPrice *= 0.95; //discount from 5%
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice *= 0.85; //discount from 15%
            }
            else if (students >= 50)
            {
                totalPrice *= 0.50; //discount from 50%
            }

            // Estimating sport type:
            string sportType = "";

            switch (group)
            {
                case "boys":
                    switch (season)
                    {
                        case "Winter": sportType = "Judo"; break;
                        case "Spring": sportType = "Tennis"; break;
                        case "Summer": sportType = "Football"; break;                            
                    }
                    break;
                case "girls":
                    switch (season)
                    {
                        case "Winter": sportType = "Gymnastics"; break;
                        case "Spring": sportType = "Athletics"; break;
                        case "Summer": sportType = "Volleyball"; break;
                    }
                    break;
                case "mixed":;
                    switch (season)
                    {
                        case "Winter": sportType = "Ski"; break;
                        case "Spring": sportType = "Cycling"; break;
                        case "Summer": sportType = "Swimming"; break;
                    }
                    break;
            }

            // Output:
            Console.WriteLine($"{sportType} {totalPrice:F2} lv.");
        }
    }
}
