using System;

namespace _07.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string namePlayer1 = Console.ReadLine();
            string namePlayer2 = Console.ReadLine();
            string input = Console.ReadLine();

            // Playing card game and estimating points:
            int pointsPlayer1 = 0;
            int pointsPlayer2 = 0;
            int card1 = 0;
            int card2 = 0;

            while (input != "End of game")
            {
                card1 = int.Parse(input);
                card2 = int.Parse(Console.ReadLine());

                if (card1 > card2)
                {
                    pointsPlayer1 += card1 - card2;
                }
                else if (card1 < card2)
                {
                    pointsPlayer2 += card2 - card1;
                }
                else if (card1 == card2)
                {
                    Console.WriteLine("Number wars!");
                    break;
                }
                input = Console.ReadLine();
            }

            // Printing game result:
            if (card1 == card2)
            {
                card1 = int.Parse(Console.ReadLine());
                card2 = int.Parse(Console.ReadLine());

                if (card1 > card2)
                {
                    Console.WriteLine($"{namePlayer1} is winner with {pointsPlayer1} points");
                }
                else
                {
                    Console.WriteLine($"{namePlayer2} is winner with {pointsPlayer2} points");
                }
            }
            else if (input == "End of game")
            {
                Console.WriteLine($"{namePlayer1} has {pointsPlayer1} points");
                Console.WriteLine($"{namePlayer2} has {pointsPlayer2} points");
            }
        }
    }
}
