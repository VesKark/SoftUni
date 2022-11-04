using System;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            // Output:
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
