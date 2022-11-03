using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int period = int.Parse(Console.ReadLine()); //days

            int treated = 0;            
            int untreated = 0;            
            int countDoctors = 7;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && treated < untreated)
                {
                    countDoctors++;
                }

                int patients = int.Parse(Console.ReadLine());

                if (patients <= countDoctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += countDoctors;
                    untreated += patients - countDoctors;
                }
            }

            // Output:
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
