using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int bottles = int.Parse(Console.ReadLine());
            int preparatML = bottles * 750; //washin preparat [ml]

            string washing = Console.ReadLine();
            int dishes = 0;
            int counter = 0;
            int countPlates = 0;
            int countPots = 0;

            // Dishwashing:
            while (washing != "End")
            {
                dishes = int.Parse(washing);
                counter++;

                if (counter % 3 == 0)
                {
                    preparatML -= dishes * 15;
                    countPots += dishes;
                }
                else
                {
                    preparatML -= dishes * 5;
                    countPlates += dishes;
                }

                if (preparatML < 0)
                {
                    break;
                }

                washing = Console.ReadLine();
            }

            // Output:
            if (preparatML >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countPlates} dishes and {countPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {preparatML} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(preparatML)} ml. more necessary!");
            }
        }
    }
}
