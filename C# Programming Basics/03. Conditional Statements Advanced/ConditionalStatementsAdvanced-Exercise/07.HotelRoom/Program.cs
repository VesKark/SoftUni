using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string month = Console.ReadLine(); //"May", "June", "July", "August", "September" or "October"
            int nights = int.Parse(Console.ReadLine()); //nights at the hotel

            // Calculating costs for stay at the hotel:            
            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    if (nights <= 7)
                    {
                        studioPrice = nights * 50.00;
                        apartmentPrice = nights * 65.00;
                    }
                    else if (nights <= 14)
                    {
                        studioPrice = nights * 50.00 * 0.95; //discount 5%
                        apartmentPrice = nights * 65.00;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 50.00 * 0.70; //discount 30%
                        apartmentPrice = nights * 65.00 * 0.90; //discount 10%
                    }
                    break;
                case "June":
                case "September":
                    if (nights <= 14)
                    {
                        studioPrice = nights * 75.20;
                        apartmentPrice = nights * 68.70;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 75.20 * 0.80; //discount 20%
                        apartmentPrice = nights * 68.70 * 0.90; //discount 10%
                    }
                    break;
                case "July":
                case "August":
                    if (nights <= 14)
                    {
                        studioPrice = nights * 76.00;
                        apartmentPrice = nights * 77.00;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 76.00;
                        apartmentPrice = nights * 77.00 * 0.90; //discount 10%
                    }
                    break;
            }

            // Output price:
            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
