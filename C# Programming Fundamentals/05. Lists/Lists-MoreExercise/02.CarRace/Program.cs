using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> carSpeed = Console.ReadLine().Split().Select(int.Parse).ToList();
            int raceLength = carSpeed.Count / 2;
            
            double racerOne = RacerTime(carSpeed, raceLength);
            carSpeed.Reverse();
            double racerTwo = RacerTime(carSpeed, raceLength);

            if (racerOne < racerTwo)
            {
                Console.WriteLine("The winner is left with total time: {0}", Math.Round(racerOne, 1));
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0}", Math.Round(racerTwo, 1));
            }
        }

        static double RacerTime(List<int> speed, int length)
        {
            double racerTime = 0;
            for (int i = 0; i < length; i++)
            {
                racerTime += speed[i];

                if (speed[i] == 0)
                {
                    racerTime *= 0.80; //time reduction by 20%
                }
            }
            return racerTime;
        }
    }
}
