using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - day of the week:
            string dayOfWeek = Console.ReadLine();

            // Output - ticket price:
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":                
                case "Friday":
                    Console.WriteLine(12); break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14); break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16); break;
            }
        }
    }
}
