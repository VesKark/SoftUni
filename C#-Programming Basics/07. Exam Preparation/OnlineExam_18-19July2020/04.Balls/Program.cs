using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int ballsNr = int.Parse(Console.ReadLine());

            // Counting points:
            string color = "";
            int countRed = 0;
            int countOrange = 0;
            int countYellow = 0;
            int countWhite = 0;
            int pointsSum = 0;
            int countDivider = 0;
            int countOther = 0;

            for (int i = 0; i < ballsNr; i++)
            {
                color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        countRed++;
                        pointsSum += 5;
                        break;
                    case "orange":
                        countOrange++;
                        pointsSum += 10;
                        break;
                    case "yellow":
                        countYellow++;
                        pointsSum += 15;
                        break;
                    case "white":
                        countWhite++;
                        pointsSum += 20;
                        break;
                    case "black":
                        pointsSum /= 2;
                        countDivider++;
                        break;
                    default:
                        countOther++;
                        break;
                }
            }

            // Output:
            Console.WriteLine($"Total points: {pointsSum}\n" +
                $"Points from red balls: {countRed}\n" +
                $"Points from orange balls: {countOrange}\n" +
                $"Points from yellow balls: {countYellow}\n" +
                $"Points from white balls: {countWhite}\n" +
                $"Other colors picked: {countOther}\n" +
                $"Divides from black balls: {countDivider}");
        }
    }
}
