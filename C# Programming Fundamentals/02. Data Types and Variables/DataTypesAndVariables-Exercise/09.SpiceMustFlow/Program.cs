using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input starting mine yield:
            int startYield = int.Parse(Console.ReadLine());

            // Extracting yield and consuming spice:
            int producedSplice = 0;
            int countDays = 0;

            while (startYield >= 100)
            {
                countDays++;
                producedSplice += startYield - 26;
                startYield -= 10;
            }

            if (producedSplice >= 26)
            {
                producedSplice -= 26;
            }

            // Output working days and extracted splice:
            Console.WriteLine(countDays);
            Console.WriteLine(producedSplice);
        }
    }
}
