using System;

namespace _07.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondPlayer = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // Easter battle:
            while (input != "End of battle")
            {
                if (input == "one")
                {
                    eggsSecondPlayer--;
                }
                else if (input == "two")
                {
                    eggsFirstPlayer--;
                }

                if (eggsFirstPlayer == 0 || eggsSecondPlayer == 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            // Output battle results:
            if (eggsFirstPlayer == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
            }
            else if (eggsSecondPlayer == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
            }
            else if (input == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
            }
        }
    }
}
