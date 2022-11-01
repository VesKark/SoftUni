using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int tankLength = int.Parse(Console.ReadLine()); //tank length in cm
            int tankWidth = int.Parse(Console.ReadLine()); //tank width in cm
            int tankHeight = int.Parse(Console.ReadLine()); //tank height in cm
            double filledPercentage = double.Parse(Console.ReadLine()); //already filled volume in %

            int tankVolume = tankLength * tankWidth * tankHeight;
            double volumeToBeFilled = tankVolume * (1 - filledPercentage / 100);

            Console.WriteLine(volumeToBeFilled / 1000); //result in Liter
        }
    }
}
