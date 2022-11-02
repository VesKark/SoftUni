using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int examHour = int.Parse(Console.ReadLine()); //[0 to 23]
            int examMinute = int.Parse(Console.ReadLine()); //[0 to 59]
            int arrivalHour = int.Parse(Console.ReadLine()); //[0 to 23]
            int arrivalMinute = int.Parse(Console.ReadLine()); //[0 to 59]

            // Estimating if "Late", "On time" or "Early":
            int diff = 0;

            int totalExam = examHour * 60 + examMinute;
            int totalArrival = arrivalHour * 60 + arrivalMinute;

            if (totalExam == totalArrival)
            {
                Console.WriteLine("On time");
            }
            else if (totalExam > totalArrival)
            {
                diff = totalExam - totalArrival;
                if (diff <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else if (diff < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diff / 60}:{diff % 60:D2} hours before the start");
                }
            }
            else if (totalExam < totalArrival)
            {
                diff = totalArrival - totalExam;
                if (diff < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diff} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diff / 60}:{diff % 60:D2} hours after the start");
                }
            }            
        }
    }
}
