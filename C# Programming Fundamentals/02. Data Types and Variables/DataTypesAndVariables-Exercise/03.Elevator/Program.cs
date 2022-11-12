using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int numberPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            // Estimate elevator courses:
            double elevatorCourses = Math.Ceiling(numberPeople * 1.00 / elevatorCapacity);
            Console.WriteLine(elevatorCourses);
        }
    }
}
